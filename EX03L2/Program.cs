//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     
// e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

// − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
// − Triângulo    Isóscele:      possui    2    lados    iguais.     
//− Triângulo    Escaleno:         possui    3    lados    diferentes.

float lado1, lado2, lado3;

Console.WriteLine("Medida lado 1");
lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Medida lado 2");
lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Medida lado 3");
lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
{
    Console.WriteLine("Triângulo    Equilátero");
}

else if (lado1 == lado2)
{
    Console.WriteLine("Triângulo    Isóscele");
}

else
{
     Console.WriteLine(" Triângulo    Escaleno");
}