using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            List<int> cisla = new List<int>();




            for (int i = 0; i < 20; i++)
            {
                cisla.Add(rnd.Next(-100, 100));
            }
            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine(cisla[n]);
            }
            Console.WriteLine("\n\n\n");

            Console.WriteLine(minimum(cisla));
            Console.WriteLine(maximum(cisla));
            sorting(cisla);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(cisla[i]);
            }

            Console.WriteLine("=========="+prumer(cisla)+"==========");

            int minimum(List<int> cisla)
            {
                int cislo = cisla[0];
                foreach (var input in cisla)
                    if (input < cislo) { cislo = input; }
                return cislo;
            }

            int maximum(List<int> cisla)
            {
                int cislo = cisla[0];
                foreach (var input in cisla)
                    if (input > cislo) { cislo = input; }
                return cislo;
            }

            void sorting(List<int> cisla)
            {
                List<int> tosort = new List<int>();
                int counc = (cisla.Count());
                for (int i = 0; i < counc; i++)
                {
                    int del = minimum(cisla);
                    tosort.Add(del);
                    cisla.Remove(del);
                }
                for (int i = 0; i < tosort.Count(); i++)
                {
                    cisla.Add(tosort[i]);
                }
            }

            double prumer(List<int> cisla)
            {
                List<int> sorted = new List<int>();

                // list s cislz na primer
                foreach (int cislo in cisla)
                {
                    if (cislo > 0 && cislo < 100 && cislo % 2 == 0)
                    {
                        sorted.Add(cislo);
                    }
                }

                int soucet = 0;
                foreach (int cislo in sorted) {
                    soucet += cislo;
                }

                double prumer = soucet / sorted.Count();

                return prumer;
            }


        }
    }
    }
