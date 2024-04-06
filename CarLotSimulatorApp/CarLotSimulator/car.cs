using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }



        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkVoice(string honkVoice)
        {
            Console.WriteLine(honkVoice);
        }

        public Car(string make, string model, int year, bool isdriveable, string EngineNoise, string HonkNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isdriveable;
        }
        



    }
}
