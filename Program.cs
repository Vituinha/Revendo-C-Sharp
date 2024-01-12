using System;
using System.Threading;

namespace StopWatch
{
    class Program{
        static void Main (String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos\nM = Minuto => 1m = 1 minuto\n0 = Sair\nQuanto tempo deseja contar?");
            String data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            //Substring pega uma quantidade (segunda variável) selecionada começando pela primeira variável
            //Lenght pega a quantidade de caracteres que uma string possui
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            Start(time);
        }
        static void Start(int time)
        {
            for(int currentTime = 1; currentTime <= time; currentTime++)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
