using System.Collections;

namespace Session_01
{
    internal class Program
    {
        public static void ReverseArrList(ArrayList arrList)
        { 
            for (int i = 0; i < arrList.Count / 2;i++)
            {
                var temp = arrList[i];
                arrList[i] = arrList[arrList.Count - 1 - i];
                arrList[arrList.Count - 1 - i] = temp;
            }
        }

        public static List<int> GetEvenNumbersInList(List<int> list)
        {
            List<int> EvenNumberList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    EvenNumberList.Add(list[i]);
                }
            }
            return EvenNumberList;
        }

        static void Main(string[] args)
        {
            #region Q1 
            //Range<int> Range01 = new Range<int>(1, 10);
            //Console.WriteLine($"Range Length: {Range01.Length()}");
            //Console.WriteLine($"Is 5 in Range: {Range01.IsInRange(5)}");
            //Console.WriteLine($"Is 15 in Range: {Range01.IsInRange(15)}");

            //Range<double> Range02 = new Range<double>(1.5, 10.5);
            //Console.WriteLine($"Range Length: {Range02.Length()}");
            //Console.WriteLine($"Is 5.5 in Range: {Range02.IsInRange(5.5)}");
            //Console.WriteLine($"Is 15.5 in Range: {Range02.IsInRange(15.5)}");

            #endregion

            #region Q2
            //ArrayList arrayList = new ArrayList() {1, 10, 100, 1000, 10000, 100000};

            //Console.WriteLine("Original ArrayList:");

            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //ReverseArrList(arrayList);

            //Console.WriteLine("Reversed ArrayList:");

            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> EvenNumberList = GetEvenNumbersInList(list);
            //Console.WriteLine("Even Numbers in List:");
            //foreach (int item in EvenNumberList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
