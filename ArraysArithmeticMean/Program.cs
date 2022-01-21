using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { -1, 6, -4, 7, -25};
            int[] arr1 = new[] { 2, 5, 3, 24, 9 };
            int sum = 0;
            int mean = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                mean = sum / arr.Length;
            }
         
            Console.WriteLine("Среднее арифметическое ="+mean);
            Console.WriteLine("Количество елемента массива =" + arr.Length);

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 0)
                {
                    count++;
                }
            count = 0;
            Array.Resize(ref arr1, arr1.Length + 1);
            arr1[arr1.Length - 1] = arr1[count];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {

                    arr1[count] = arr[i];
                    count++;
                }

            }

            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.ReadKey();
        }
       
    }
}
