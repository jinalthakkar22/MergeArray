using System;
using System.Collections.Generic;

namespace TESTAPP25082022
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeArray();
            Console.Read();
        }
        static void MergeArray()
        {
            int arrStr1Length, arrStr2Length;
            Console.WriteLine("Enter Length of Array1:");
            arrStr1Length = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter string of Array1 : ");
            string[] arr1 = new string[arrStr1Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter Length of Array2:");
            arrStr2Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string of Array2 : ");
            string[] arr2 = new string[arrStr2Length];
            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = Console.ReadLine();
            }

            List<string> lstResult = new List<string>();

            for (int i = 0; i < arr1.Length + arr2.Length; ++i)
            {

                string item = i < arr1.Length ? arr1[i] : arr2[i - arr1.Length];

                if (!lstResult.Contains(item))
                {
                    lstResult.Add(item);
                }

            }
			
			Console.WriteLine("\nArray1 : ");
            Console.Write("[ ");
            Console.Write(string.Join(", ", arr1));
            Console.Write(" ]");
			
			Console.WriteLine("\nArray2 : ");
            Console.Write("[ ");
            Console.Write(string.Join(", ", arr2));
            Console.Write(" ]");
			
			
            Console.WriteLine("\nResult : ");
            Console.Write("[ ");
            Console.Write(string.Join(", ", lstResult.ToArray()));
            Console.Write(" ]");
        }
    }
}


