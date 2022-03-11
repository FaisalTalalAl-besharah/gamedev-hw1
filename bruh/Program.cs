using System;

namespace bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] HealthArray = { "damaged", "boosted" };
            {
                void damaged()
                {
                    int health = 100;
                    int damaged = 20;
                    Console.WriteLine("Damaged health : {0}", health - damaged);
                }
                damaged();
                void boosted()
                {
                    int health2 = 80;
                    int boost = 10;
                    Console.WriteLine("Boosted health : {0}", health2 + boost);
                }
                boosted();
                Console.WriteLine("80 is less than 90");
            }
        }
    }
}
