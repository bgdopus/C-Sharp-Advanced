using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string az = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabet = az.ToCharArray();
            
            // tursim duljina na shifar
            List<int> list = new List<int>();
            for (int f = message.Length -1 ; f >0 ; f--)
            {
                if (char.IsDigit(message[f]))
                {
                    list.Add(int.Parse(message[f].ToString()));
                }
                else
                {
                    break;
                }
            }
            list.Reverse();
            string cypherS = null;

            for (int g = 0; g < list.Count; g++)
            {
                cypherS += cypherS + list[g];
            }
            int cypherSize = int.Parse(cypherS);

            
            
            message = message.Remove(message.Length-list.Count);
            string cypher = message.Substring(message.Length - cypherSize);
            message = message.Remove(message.Length-cypherSize, cypherSize);

            List<char> messList = new List<char>();
            for (int t = 0; t < message.Length; t++)
            {
                if (char.IsDigit(message[t]))
                {
                    for (int b = 0; b < int.Parse(message[t].ToString()); b++)
                    {
                        messList.Add(message[t+1]);
                    }
                    t++;
                }
                else
                {
                    messList.Add(message[t]);
                }
            }
            int[] messCode = new int[messList.Count];
            

            for (int i = 0; i < messList.Count; i++)
            {
                messCode[i] = az.IndexOf(messList[i]);
            }

            int[] cypherCode = new int[cypherSize];
            for (int i = 0; i < cypherSize; i++)
            {
                cypherCode[i] = az.IndexOf(cypher[i]);
            }

            int cypherCounter = 0;

            int[] final =  new int[messCode.Length];

            for (int f = 0; f < messCode.Length; f++)
            {
                if (cypherCounter == cypherSize)
                {
                    cypherCounter = 0;
                }

                int bitwise = messCode[f] ^ cypherCode[f];
                bitwise += 65;
                final[f] = bitwise;
                cypherCounter++;
            }

            char c = Convert.ToChar(final[0]);
            Console.WriteLine(c);

        }
    }
}
