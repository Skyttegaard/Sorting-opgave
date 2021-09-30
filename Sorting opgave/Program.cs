using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sorting_opgave
{
    class Program
    {
        static List<int> testing = new() { 6, 2, 8, 4, 1, 9, 4,2 ,5 ,1 ,443 , 2142, 42, 4,234 ,23,4, 23,4, 2,34 ,23,4, 2,5 ,235, 23,5 ,23 ,23, 3,3 };
        
        
        static void Main(string[] args)
        {
            PrintText();
        }
        public static void PrintText()
        {
            foreach(int i in testing)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine("\nSorted:\n");
            testing.Sorting(0,testing.Count-1);
            foreach(int i in testing)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }





        

        
    }
}
