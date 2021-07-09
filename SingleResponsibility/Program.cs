using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };

            BubbleSort bubbleSort = new BubbleSort();

            Console.WriteLine("Asc: " + bubbleSort.DisplayArray(bubbleSort.Sort(arr, bubbleSort.Asc)));

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Des: " + bubbleSort.DisplayArray(bubbleSort.Sort(arr, bubbleSort.Des)));
        }
    }
}
