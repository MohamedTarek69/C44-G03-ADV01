using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    // Generic Class
    internal static class Helper<T>
    {
        public static void Print(T X)
        {
            Console.WriteLine(X);
        }
        // Genaric Method
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
