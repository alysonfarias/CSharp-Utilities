using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashSet Complexity O(1)
            HashSet<string> conjunto = new HashSet<string>();

            conjunto.Add("Sofa");
            conjunto.Add("TV");
            conjunto.Add("Tablet");

            Console.WriteLine(conjunto.Contains("TV"));
            Console.WriteLine(conjunto.Contains("Computer"));

            //foreach (var item in conjunto)
            //{
            //    Console.WriteLine(item);
            //}


            // SortedSet Complexity O(log(n))
            SortedSet<int> conjuntoSorted = new SortedSet<int>() { 10, 0, 2, 4, -2, 1, 7, 1, -1 };
            SortedSet<int> conjuntoSortedB = new SortedSet<int>() { 8, 9, 10 };


            // union
            SortedSet<int> conjuntoSortedC = new SortedSet<int>(conjuntoSortedB);
            //conjuntoSorted.UnionWith(conjuntoSortedB);
            //PrintCollection(conjuntoSorted);


            // intersection
            //conjuntoSorted.IntersectWith(conjuntoSortedB);
            //PrintCollection(conjuntoSorted);

            // difference
            //conjuntoSorted.ExceptWith(conjuntoSortedB);
            //PrintCollection(conjuntoSorted);
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
