using System;

namespace console_quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int quadrado = 0;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            var calculadoraQuadrado = new Quadrado();
            quadrado = calculadoraQuadrado.ComParametro(numero); 

            Console.WriteLine("O quadrado do número é: " + quadrado);

            calculadoraQuadrado.Valor = numero; 
            quadrado = calculadoraQuadrado.SemParametro();
            Console.WriteLine("O quadrado do número é: " + quadrado);
            Console.ReadKey();

    }
    }
}
