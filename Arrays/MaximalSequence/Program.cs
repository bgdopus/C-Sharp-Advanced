using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            int bigcounter = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j -1] == nums[j])
                {
                    counter++;
                }
                else
                {
                    
                    if (counter>bigcounter)
                    {
                        bigcounter = counter;
                        
                    }
                    counter = 0;
                }
                
            }
            Console.WriteLine(bigcounter+1);
        }
    }
}
