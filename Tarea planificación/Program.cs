using System;

namespace Tarea_planificación
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int quantityVowels(string word)
        {
            int quantity = 0;
            string vowels = "aeiou";
            word = word.ToLower().Trim();

            for(int i = 0; i < vowels.Length; i++)
            {
                for(int j = 0; j < word.Length; j++)
                {
                    if (word[j].Equals(vowels[i]))
                    {
                        quantity++;
                    }
                }
               
            }

            return quantity;
        }
        public static int factorial(int num)
        {
            int data = 1;
            if(num == 0)
            {
                return 1;
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    data *= i;
                }
            }
            return data;
        }
    }
}
