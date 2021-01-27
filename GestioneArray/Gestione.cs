using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneArray
{
    public class Gestione
    {
        private static int[] array = new int[10];

        public static void Riempimento(bool scelta)
        {
            if(scelta == true)
            {
                Random r = new Random();
                for(int c = 0; c < array.Length;c++)
                {
                    array[c] = r.Next();
                }
            }
            else
            {
                int c;
                for (c = 0; c < array.Length;c++)
                {
                    Console.Write($"Inserisci il {c + 1}° numero nella posizione {c}: ");
                    array[c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static void Stampa(bool scelta1)
        {
            if(scelta1 == true)
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

        public static int[] MaxMinArray()
        {
            int max = array[0];
            int min = array[0];
            int[] maxmin = new int[array.Length];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxmin[i] = array[i];

                }

                if (array[i] < min)
                {
                    min = array[i];
                    maxmin[i] = array[i];
                }
            }
            return maxmin;
        }

        public static void StampaMaxMin(int[] maxmin)
        {

        }
    }
}
