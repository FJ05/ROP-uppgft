using System;

namespace ROG1
{
    class Program
    {
        static void Main(string[] args)
        {
           //värde mängden av pilen
           int arrowPos = 1;
           //gör så att koden loopar i oändllighet efterson att 1 kommer altid vara lika med 1
           while (1 == 1) 
           {
            Console.Clear();
            if (arrowPos == 5) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.WriteLine("test text one"); Console.ResetColor(); if (arrowPos == 4) { Console.ForegroundColor = ConsoleColor.Green; }
            
            Console.WriteLine("test text two"); Console.ResetColor(); if (arrowPos == 3) { Console.ForegroundColor = ConsoleColor.Green; }

            Console.WriteLine("test text three"); Console.ResetColor(); if (arrowPos == 2) { Console.ForegroundColor = ConsoleColor.Green; }
            
            Console.WriteLine("test text four"); Console.ResetColor(); if (arrowPos == 1) { Console.ForegroundColor = ConsoleColor.Green; }
            
            Console.WriteLine("test text five");
            Console.ResetColor();

                switch (Console.ReadLine()) 
            {
                //om användaren skriver in w eller W kommer det hända samma sak
                case "w":
                case "W":
                    //så länge arrowPos är inte högre än 5 läggs +1 till värdet
                    if (arrowPos < 5) { arrowPos++; }
                    //ger värdet 1 till pil positionen
                    else { arrowPos = 1; }
                    break;

                //om användaren skriver in s eller S kommer det hända samma sak
                case "s":
                case "S":
                    //-1 på position värdet om arrowPos inte är lika med 1
                    if (arrowPos != 1) { arrowPos--; }
                    //ger värdet 5 till pil positionen
                    else { arrowPos = 5; }
                    break;

                case "E":
                case "e":

                        break;

                default:
                    break;
            }
           }

        }
    }
}
