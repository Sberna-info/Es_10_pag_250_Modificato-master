
using System;
using GestioneArray;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaArray
{
    class Program
    {
        private static int[] array = new int[3];
        static void Main(string[] args)
        {
            double[] arrayMaxMin = new double[array.Length];
            Console.Write("Se vuoi riempire l'array casualmente digita 1, Se invece lo vuoi riempire manualmente digita 2: ");
            bool riempi = Console.ReadLine() == "1";
            Riempimento(riempi);
            Console.Write("Se vuoi visualizzare l'array da destra verso sinistra digita 1, se invece lo vuoi vedere da sinistra verso destra digita 2: ");
            bool stampa = Console.ReadLine() == "1";
            Stampa(stampa);
            arrayMaxMin = MaxMinMediaArray();
            Console.WriteLine($"il min è {arrayMaxMin[0]} e il max è {arrayMaxMin[1]} e la media è {arrayMaxMin[2]}");
            Console.ReadLine();
        }
        public static void Riempimento(bool scelta)
        {
            if (scelta == true)
            {
                Random r = new Random();
                for (int c = 0; c < array.Length; c++)
                {
                    array[c] = r.Next(0, 1000);
                }
            }
            else
            {
                int c;
                for (c = 0; c < array.Length; c++)
                {
                    Console.Write($"Inserisci il {c + 1}° numero nella posizione {c}: ");
                    array[c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static void Stampa(bool scelta1)
        {
            if (scelta1 == true)
            {
                for (int c = 0; c < array.Length; c++)
                    Console.Write($"{array[c]} ");
            }
            else
            {
                for (int c = array.Length - 1; c >= 0; c--)
                    Console.Write($"{array[c]} ");
            }
            Console.WriteLine();
        }

        public static double[] MaxMinMediaArray()
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int somma = 0, count = 0;
            double media = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];

                }

                if (array[i] < min)
                {
                    min = array[i];
                }

                somma += array[i];
                count++;
            }
            media = somma / count;
            return new double[] { min, max, media };
        }
    }
}
