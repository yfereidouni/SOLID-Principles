using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{

    public class BubbleSort
    {
        public Func<int, int, bool> Asc = (a, b) => a > b;

        public Func<int, int, bool> Des = (a, b) => a < b;

        public int[] Sort(int[] arr, Func<int, int, bool> sortDirection)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (sortDirection.Invoke(arr[i], arr[i + 1]))
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

        public string DisplayArray(int[] arr)
        {
            string temp = string.Empty;

            foreach (var item in arr)
            {
                temp += item + " ";
            }

            return temp;
        }
    }
}
