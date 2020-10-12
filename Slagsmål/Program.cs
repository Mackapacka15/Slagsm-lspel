using System;

namespace Slagsmål
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spel = true;
            while (spel == true)
            {
                Random generator = new Random();
                bool liv = true;
                int hp1 = 30;
                int hp2 = 30;
                string Spelare2 = "";
                //Vilket namn ska spelare 2 ha.
                Spelare2 = spelare2namn();
                int runda = 1;
                Console.WriteLine("Vad ska din kämpe heta?");
                string Spelare1 = Console.ReadLine();
                Console.WriteLine("Du möter: " + Spelare2);
                while (liv == true)
                {
                    int slag1 = generator.Next(0, 11);
                    int slag2 = generator.Next(0, 11);
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
                        Console.WriteLine(Spelare1 + " missade.");
                        Console.WriteLine(Spelare2 + " gjorde " + (slag2 + "") + " skada");
                        Console.WriteLine("");
                    }
                    else if (slag2 == 0)
                    {
                        Console.WriteLine(Spelare1 + " gjorde " + (slag1 + "") + " skada");
                        Console.WriteLine(Spelare2 + " Missade.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(Spelare1 + " gjorde " + (slag1 + "") + " skada");
                        Console.WriteLine(Spelare2 + " gjorde " + (slag2 + "") + " skada");
                        Console.WriteLine("");
                    }
                    if (hp1 <= 0 && hp2 <= 0)
                    {
                        Console.WriteLine("Det blev lika");
                        liv = false;
                    }
                    else if (hp1 <= 0 || hp2 <= 0)
                    {
                        liv = false;
                        if (hp1 <= 0)
                        {
                            Console.WriteLine(Spelare2 + " vann.");
                        }
                        else if (hp2 <= 0)
                        {
                            hp2 = 0;
                            Console.WriteLine(Spelare1 + " vann.");
                        }

                    }


                    if (liv == true)
                    {
                        Console.WriteLine(Spelare1 + " har " + hp1 + " hp kvar");
                        Console.WriteLine(Spelare2 + " har " + hp2 + " hp kvar");

                        Console.WriteLine("Tryck på enter för nästa runda");
                        Console.ReadLine();
                        runda++;
                    }
                }
                Console.WriteLine("Vill du köra en gång till?");
                string igen1 = Console.ReadLine();
                igen1 = igen1.ToLower();
                if (igen1 == "ja")
                {
                    spel = true;
                }
                else
                {
                    spel = false;
                }
            }
            Console.ReadLine();
        }
        static string spelare2namn()
        {
            string[] namn = { "Steve", "Alex", "Creeper" };

            Random generator = new Random();

            int i =generator.Next(namn.Length);
            return namn[i];
        }
    }
}
