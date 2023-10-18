using System;
using System.Linq.Expressions;

namespace inlämningsuppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int störstgårförst = 0;
           bool avsluta=false;

            while (avsluta != true)
            {
                try
            {
               
                    Console.WriteLine("Vill du skriva ett heltal till? Om inte skriv 'n', annars skriv fler");
                    string svar = Console.ReadLine();
                    if (svar == "n")
                    {
                        avsluta = true;
                    }
                    else if (störstgårförst < int.Parse(svar))
                    {
                        störstgårförst = int.Parse(svar);
                    }



                }
            
            catch
            {
                Console.WriteLine("Du måste skriva ett heltal eller n");

            }
            }
               Console.WriteLine("Ditt största tal var " + störstgårförst);

            }
        }
    }
