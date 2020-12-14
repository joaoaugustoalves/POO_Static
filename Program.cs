using System;

namespace POO_Statc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes estáticas não podem ser instanciadas

            // Em que momento usamos classes estáticas ?
            // QUando precisarmos de uma solução que pode servir para qualquer tipo de aplicação

            // Em que momento não usamos classes estáticas?
            // Quando tivermos objetos/classes que são especificos de um tipo de aplicação


            Console.WriteLine(Math.Pow(2, 5) );

            Console.WriteLine("Digite um valor : ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());


            Console.WriteLine( Conversor.ConverterDolarParaReal(3f) );

            Console.WriteLine(Conversor.ConverterRealParaDolar(200f) );



            Console.WriteLine(Conversor.ConverterEuroParaReal(3f) );

            Console.WriteLine(Conversor.ConverterRealParaEuro(200f) );

            
            // este método tbm tem que ser static na sua declaração
            Testar();
        }

        static void Testar(){

        }
    }
}
