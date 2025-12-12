using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E61646C31AB2F", IsUnique = true)]
[Index("Nomeusuario", Name = "UQ__tb_usuar__CBB6AA36E3CAAC9A", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nomecompleto")]
    [StringLength(250)]
    public string Nomecompleto { get; set; } = null!;

    [Column("nomeusuario")]
    [StringLength(150)]
    public string Nomeusuario { get; set; } = null!;

    [Column("email")]
    [StringLength(250)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("fotoperfilurl")]
    [StringLength(150)]
    public string? Fotoperfilurl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbComentario> TbComentario { get; set; } = new List<TbComentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacao { get; set; } = new List<TbPublicacao>();

    [ForeignKey("IdUsuarioseguir")]
    [InverseProperty("IdUsuarioseguir")]
    public virtual ICollection<TbUsuario> IdUsuarioseguindo { get; set; } = new List<TbUsuario>();

    [ForeignKey("IdUsuarioseguindo")]
    [InverseProperty("IdUsuarioseguindo")]
    public virtual ICollection<TbUsuario> IdUsuarioseguir { get; set; } = new List<TbUsuario>();
}
