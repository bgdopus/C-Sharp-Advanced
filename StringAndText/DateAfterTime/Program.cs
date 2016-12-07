using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfterTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "dd.MM.yyyy HH:mm:ss";   // Use this format.
            TimeSpan timeADD = new TimeSpan(0, 60, 30, 0);
            DateTime combined = time.Add(timeADD);
            Console.WriteLine(combined.ToString(format));
        }
    }
}
