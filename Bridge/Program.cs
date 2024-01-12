using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    internal class Program
    {
        static void StartLive(IPlattform plattform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(plattform);

            live.Broadcasting();
            live.Result();
        }
        static void StartAdvancedLive(IPlattform plattform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(plattform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
            
        }

        static void Main(string[] args)
        {
            StartAdvancedLive(new Youtube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());

            
            Console.ReadKey();
        }


    }
}
