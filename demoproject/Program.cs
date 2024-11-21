using System.Globalization;
using System.Reflection;
using System.Text;

namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Console.WriteLine("Hello, World!");
            //    Console.WriteLine("Hello Ullagam");
            #region Reading Input 

            #endregion

            #region 1D Array
            string[] names;
            string[] cities = new string[] { "Erode","Salem","chennai"};
            //Access individual elements of an array
            Console.WriteLine(cities[2]);//chennai
            //using for loop
            for(int i=0;i<cities.Length;i++)
            {
                Console.WriteLine(cities[i]);
            }
            //using foreach
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //sorting an array
            int[] marks = new int[] { 9,5,7,3,4,1};
            Array.Sort(marks);
            Console.WriteLine("Ascending:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
            //reversing (descending order )
            Array.Reverse(marks);
            Console.WriteLine("Descending:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
            //searching for an element in an array
            string key = "Salem";
            string result=Array.Find(cities,c=> c==key);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("key not found");
            }
            #endregion

            #region 2D Array

            int[,] studentMarks = new int[2, 2]
                {
                    {1,100},
                    {2,90 }
                };
            Console.WriteLine(studentMarks[0,0]);//1
            #endregion

            //declare a jagged array
            int[][] jaggedArray = new int[2][];//two 1 dimensional array
            // initialize the array
            jaggedArray[0] = new int[] {1,2 };
            jaggedArray[0] = new int[] { 3,4,5 };
            Console.WriteLine(jaggedArray[0][0]);//1
            Console.WriteLine(jaggedArray[1][0]);//3
            



            
        }
    }
}
