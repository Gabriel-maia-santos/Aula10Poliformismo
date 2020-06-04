using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Mario: ");
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();

            System.Console.WriteLine("---------------------------------------------");


            System.Console.WriteLine("Luigi: ");
            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
        }
    }
}
