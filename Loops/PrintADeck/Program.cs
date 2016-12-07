using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] arr = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string card = Console.ReadLine();
            int lastCard = 2;
            switch (card)
            {
                case "2": lastCard = 2;
                    break;
                case "3":
                    lastCard = 3;
                    break;
                case "4":
                    lastCard = 4;
                    break;
                case "5":
                    lastCard =5;
                    break;
                case "6":
                    lastCard = 6;
                    break;
                case "7":
                    lastCard = 7;
                    break;
                case "8":
                    lastCard = 8;
                    break;
                case "9":
                    lastCard = 9;
                    break;
                case "10":
                    lastCard = 10;
                    break;
                case "J":
                    lastCard = 11;
                    break;
                case "Q":
                    lastCard = 12;
                    break;
                case "K":
                    lastCard = 13;
                    break;
                case "A":
                    lastCard = 14;
                    break;
                default:
                    break;
            }
            List<int> list = new List<int>();
            string[] arr = new string[] { "of spades", "of clubs", "of hearts", "of diamonds" };
            string[] bigCards = new string[] { "","2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 2; i < lastCard; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i <= 10)
                    {
                        Console.Write("{0} {1}", i, arr[j]);
                        Console.Write("{0}", (j == 3) ? "" : ", ");
                    }
                    else 
                    
                    {
                        Console.Write("{0} {1}", bigCards[i], arr[j]);
                        Console.Write("{0}", (j == 3) ? "" : ", ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
