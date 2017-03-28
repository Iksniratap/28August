using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28August
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());
            wage *= exchangeRate * days;
            double fullWage = wage * 14.5;
            fullWage *= 0.75;
            double dailyWage = fullWage / 365;
            Console.WriteLine("{0:F2}", dailyWage);
        }
    }
}
