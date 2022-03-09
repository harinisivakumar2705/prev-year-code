using System;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            //l and r are the indexes of the section on the array
            int[] qs(int[] a, int l, int r)
            {
                int[] arr = new int[] {9, 0, 4, 2, 10, -10 };
                int left = 0;
                int right = arr.Length - 1;
                bool IsSorted = false;
                foreach(int i in arr)
                {
                    if(arr[left] >= arr[right])
                    {
                        break;
                    }
                }
                void partition(int[] a, int r, int l)
                {
                    int pivot = 0;
                }
                int[] sorted = new int[arr.Length];
                return sorted;
            }
        }
    }
}
