using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMetters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600f + minutes * 60f + seconds;
            float timeInHours = hours + minutes / 60f + seconds / 3600f;
            float distanceInKilometters = distanceInMetters / 1000f;
            float distancdistanceInmiles = distanceInMetters / 1609f;

            Console.WriteLine(distanceInMetters / timeInSeconds);
            Console.WriteLine(distanceInKilometters / timeInHours);
            Console.WriteLine(distancdistanceInmiles / timeInHours);


        }
    }
}
