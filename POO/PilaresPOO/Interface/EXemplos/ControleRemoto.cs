using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXemplos
{
    public class ControleRemoto
    {
        public int NivelVolume = 0;

        public int Volumemaximo = 30;
        public int VolumeMinimo = 0;

        public void AumentarVol()
        {
            if(NivelVolume == Volumemaximo)
            {
                Console.WriteLine($"Volume máximo atingido {NivelVolume}");
                return;
            }
            NivelVolume++;
            Console.WriteLine($"Volume: {NivelVolume}");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV");
            
        }

        public void DominuirVol()
        {
            if(NivelVolume == VolumeMinimo)
            {
                Console.WriteLine($"Volume Minimo atingido {NivelVolume}");
                return;
            }
             NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV");
            
        }
        
        
        
    }
}