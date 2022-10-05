using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмір масиву: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Заповніть масив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Елемент №{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Масив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.WriteLine();

            int count = 1;
            for (int i = 0; i < arr.Length - 1; i += count)
            {
                count = 1;
                int temp = arr[i];
                if (arr[i] == arr[i + 1])
                    arr[i]++;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (temp == arr[i + j])
                    {
                        arr[i + j]++;
                        count++;
                    }
                }
            }

            Console.Write("Резуьтат: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]);

            Console.Read();
        }
    }
}
