using System;

namespace Slagsmål
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp1 = 30;
            int hp2 = 30;
            string Namn1 = "Spelare 1";
            string Namn2 = "Spelare 2";
            bool liv = true;
            int runda = 1;
            while (liv == true)
            {
                Random generator = new Random();
                int slag1 = generator.Next(0, 11);
                int slag2 = (generator.Next(10, 21) - 10);
                if (slag1 > hp2)
                {
                    slag1 = hp2;
                }
                if (slag2 > hp1)
                {
                    slag2 = hp1;
                }
                Console.WriteLine("Runda " + runda);
                hp1 = hp1 - slag2;
                hp2 = hp2 - slag1;
                if (slag1 == slag2)
                {
                    Console.WriteLine("Båda gjorde " + slag1 + " skada.");
                }
                else if (slag1 == 0)
                {
                    Console.WriteLine(Namn1 + " missade.");
                    Console.WriteLine(Namn2 + " gjorde " + (slag2 + "") + " skada");
                    Console.WriteLine("");
                }
                else if (slag2 == 0)
                {
                    Console.WriteLine(Namn1 + " gjorde " + (slag1 + "") + " skada");
                    Console.WriteLine(Namn2 + " Missade.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(Namn1 + " gjorde " + (slag1 + "") + " skada");
                    Console.WriteLine(Namn2 + " gjorde " + (slag2 + "") + " skada");
                    Console.WriteLine("");
                }
                if (hp1 <= 0 && hp2 <= 0)
                {
                    Console.WriteLine("Det blev lika");
                }
                else if (hp1 <= 0 || hp2 <= 0)
                {
                    liv = false;
                    if (hp1 <= 0)
                    {
                        Console.WriteLine(Namn1 + " förlorade.");
                    }
                    else if (hp2 <= 0)
                    {
                        hp2 = 0;
                        Console.WriteLine(Namn2 + " förlorade.");
                    }

                }


                if (liv == true)
                {
                    Console.WriteLine(Namn1 + " har " + hp1 + " hp kvar");
                    Console.WriteLine(Namn2 + " har " + hp2 + " hp kvar");

                    Console.WriteLine("Tryck på enter för nästa runda");
                    Console.ReadLine();
                    runda++;
                }
            }
            Console.ReadLine();
        }
    }
}
