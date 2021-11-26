using System;

namespace e_migrant_grupo40_wolframe
{
     class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;

            Console.WriteLine("ingresa tu peso en kilos: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("peso ={0}", peso);
            Console.WriteLine("ingresa tu altura en metros: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("peso ={0}", altura);

            double IMC = peso / (altura * altura);
            Console.WriteLine("tu IMC es ={0}", IMC);

            if (IMC < 16)
            {
                Console.WriteLine("Delgadez severa");
            }
            else if (IMC >= 16 && IMC <= 16.99)
            {
                Console.WriteLine("Delgadez moderada");

            }
            else if (IMC >= 17 && IMC <= 18.49)
            {
                Console.WriteLine("Delgadez aceptable");

            }
            else if (IMC >= 18.5 && IMC <= 24.99)
            {
                Console.WriteLine("Peso normal");
            }
            else if (IMC >= 25 && IMC <= 29.99)
            {
                Console.WriteLine("Sobrepeso");

            }
            else if (IMC >= 30 && IMC <= 34.99)
            {
                Console.WriteLine("Obesidad tipo I");
            }
            else if (IMC >= 35 && IMC <= 39.99)
            {
                Console.WriteLine("Obesidad tipo II");
            }
            else if (IMC >= 40 && IMC <= 49.99)
            {
                Console.WriteLine("Obesidad tipo III o mórbida");
            }
            else if (IMC > 50)
            {
                Console.WriteLine("Obesidad tipo IV o extrema");
            }

        }
    }
}
