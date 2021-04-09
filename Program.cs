using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Fly f = new Fly();
            try
            {
                f.Flight();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The plane crashed");
            }



        }
    }
}
