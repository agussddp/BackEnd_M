using System.ComponentModel.DataAnnotations;
using EXemplos;

//CreditCardAttribute um objeto da classe Carro

// Carro Nissan = new Carro("Azul", "Nissan", "Kicks", 2026);
// Nissan.ExibirInfo();

// Moto Hornet = new Moto("Honda", "Hornet Carburada", "Rosa", 2011);
// Hornet.ExibirInfo();

//--------------------------------------------
//--------------------------------------------

//Criar uma interface IControle com as seguintes regras/metodos:
       //Ligar delsigar aumentarvol e diminuirvol

       //criar uma classe controleremoto que implementa a interface IControle
       // tambem deve te as propriedades NivelVolume e VOLmax

    ControleRemoto controleTv = new ControleRemoto();
    controleTv.AumentarVol();