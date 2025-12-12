using System;
using System.Collections.Generic;
using DevConnectMoura.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtidas> TbCurtidas { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83FA02B257E");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_pu__75A278F5");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_us__74AE54BC");
        });

        modelBuilder.Entity<TbCurtidas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_curti__3213E83FADCD6FF5");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtidas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_pu__71D1E811");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtidas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_us__70DDC3D8");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83F3BF77D29");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__6E01572D");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83F5AFC1D3D");

            entity.HasMany(d => d.IdUsuarioseguindo).WithMany(p => p.IdUsuarioseguir)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioseguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17F790F9"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioseguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17036CC0"),
                    j =>
                    {
                        j.HasKey("IdUsuarioseguir", "IdUsuarioseguindo").HasName("PK__tb_segui__793B6B80457221D0");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioseguir").HasColumnName("id_usuarioseguir");
                        j.IndexerProperty<int>("IdUsuarioseguindo").HasColumnName("id_usuarioseguindo");
                    });

            entity.HasMany(d => d.IdUsuarioseguir).WithMany(p => p.IdUsuarioseguindo)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioseguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17036CC0"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioseguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17F790F9"),
                    j =>
                    {
                        j.HasKey("IdUsuarioseguir", "IdUsuarioseguindo").HasName("PK__tb_segui__793B6B80457221D0");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioseguir").HasColumnName("id_usuarioseguir");
                        j.IndexerProperty<int>("IdUsuarioseguindo").HasColumnName("id_usuarioseguindo");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
