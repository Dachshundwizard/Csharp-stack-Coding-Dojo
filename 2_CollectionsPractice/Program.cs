using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            string[] arr2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arr3 = new bool[10];
            for(int i = 0; i < 10; i += 2)
            {
                arr3[i] = true;
            }
        }
    }
}
