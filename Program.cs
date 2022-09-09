using System;

namespace prvniprogram
    {
        class Animal
        {
            string name;
            int legs;
            string sound;
            public double weight;
            bool mammal;

            public bool IsHeavy()
            {
                if (this.weight > 30.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            void MakeSound()
            {
                System.Console.WriteLine(this.sound);
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                System.Console.WriteLine("salut");
                Animal zvire1 = new Animal();
                zvire1.weight = 50;
                System.Console.WriteLine(zvire1.IsHeavy());
            }
        }
    }