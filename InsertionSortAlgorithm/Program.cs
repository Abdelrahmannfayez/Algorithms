using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorithm
{
    class Program
    {
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int x = arr[i];
                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    arr[j] = x;
                    j--;
                }

            }

        }
        static void PrintArrElements(int[] arr)
        {
            Console.WriteLine("Sorted Array Elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Array Size:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Array Elements:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            InsertionSort(arr);
            PrintArrElements(arr);



        }
    }
}