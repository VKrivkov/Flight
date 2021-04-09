using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Dispatcher
    {
        string name;
        public int Correction { get; set; }
        int recHigh;
        public Dispatcher(string name)
        {
            Random r = new Random();
            this.name = name;
            Correction = r.Next(-200, 200);
        }
        public void Show()
        {
            Console.WriteLine($"{name}\tCorrection {Correction}");
        }
        public void RecHigh(Airplane plane)
        {
            recHigh = 7 * plane.Speed - Correction;
            Console.WriteLine($"Recommended flight altitude - {recHigh}");
            
        }
    }
}
