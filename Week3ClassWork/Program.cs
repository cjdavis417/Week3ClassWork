using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Big Cats v1.0 \n");
            Console.Write("Would you like to create a new Cat? y/n ");

            var initialResponse = Console.ReadLine();

            if (initialResponse == "y")
            {
                var newCat = new BigCat();
                Console.Write("What type of Cat is this? ");
                newCat.Type = Console.ReadLine();
                Console.WriteLine();
                int intParse;
                Console.Write("What is the Height of this cat? ");
                if (int.TryParse(Console.ReadLine(), out intParse))
                {
                    newCat.Height = intParse;
                } else
                {
                    Console.Write("Wrong value type. Must be number.");
                }

                Console.WriteLine();
                Console.Write("What is the Length of this cat? ");
                if (int.TryParse(Console.ReadLine(), out intParse))
                {
                    newCat.Length = intParse;
                }
                else
                {
                    Console.Write("Wrong value type. Must be number.");
                }

                Console.WriteLine();
                Console.Write("What is the adult weight of this cat? ");
                if (int.TryParse(Console.ReadLine(), out intParse))
                {
                    newCat.Weight = intParse;
                }
                else
                {
                    Console.Write("Wrong value type. Must be number.");
                }

                double doubleParse;
                Console.WriteLine();
                Console.Write("What is the Maximum running speed of this cat? ");
                if (double.TryParse(Console.ReadLine(), out doubleParse))
                {
                    newCat.Speed = doubleParse;
                }
                else
                {
                    Console.Write("Wrong value type. Must be number.");
                }


                Console.WriteLine("Type: " + newCat.Type);
                Console.WriteLine("Height: " + newCat.Height);
                Console.WriteLine("Length: " + newCat.Length);
                Console.WriteLine("Weight: " + newCat.Weight);
                Console.WriteLine("MAX Speed: " + newCat.Speed);


                newCat.OutputToFile();
                Console.WriteLine(@"The file is outputed here: C:\Users\Public\Documents\WriteLines2.txt");
                Console.ReadLine();

            }


        }

        
    }
}
