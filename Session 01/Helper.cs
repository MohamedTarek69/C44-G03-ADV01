using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    // Generic Class
    internal static class Helper<T> where T : IEquatable<T> , IComparable<T>
    {
        public static void BubbleSort(T[] array)
        {
            if (array is null) return;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    //if (array[j] > array[j + 1])
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Helper<T>.SWAP(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        public static int LinearSearch(T[] arr , T target)
        {
            if (arr?.Length>0 && target is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    //if (arr[i] == target)
                    //if (arr[i]?.Equals(target)??false) 
                    if(target.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }

        public static int LinearSearch(T[] arr , T target , IEqualityComparer<T> comparer )
        {
            if (arr?.Length>0 && target is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    //if (arr[i] == target)
                    //if (arr[i]?.Equals(target)??false) 
                    //if(target.Equals(arr[i]))
                    if (comparer.Equals(arr[i], target))
                        return i;
                }
            }
            return -1;
        }



        // Genaric Method
        public static void Print(T X)
        {
            Console.WriteLine(X);
        }

        public static void SWAP(ref T x , ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


        // Passing Paramter Value Type by Value
        //public static void SWAP(ref int x , ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void SWAP(ref decimal x , ref decimal y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void SWAP(ref Point x , ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}
    }
}
