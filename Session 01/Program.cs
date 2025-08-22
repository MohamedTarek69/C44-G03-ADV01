using System.Drawing;

namespace Session_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------Vedio 01-----------------------------------
            #region SWAP
            //int a = 10, b = 20;
            //Console.WriteLine($"Before Swap: \na = {a} \nb = {b}");
            //Helper<int>.SWAP(ref a, ref b);
            //Console.WriteLine($"After Swap: \na = {a} \nb = {b}");

            //decimal M = 10.10M, L = 20.20M;
            //Console.WriteLine($"Before Swap: \nM = {M} \nL = {L}");
            //Helper<decimal>.SWAP(ref M, ref L);
            //Console.WriteLine($"After Swap: \nM = {M} \nL = {L}");

            //Point P01 = new Point(10, 20);
            //Point P02 = new Point(100, 200);
            //Console.WriteLine("Before Swap:");
            //Console.WriteLine($"P01 => {P01}");
            //Console.WriteLine($"P02 => {P02}");
            //Helper<Point>.SWAP(ref P01, ref P02);
            //Console.WriteLine("After Swap:");
            //Console.WriteLine($"P01 => {P01}");
            //Console.WriteLine($"P02 => {P02}"); 

            #endregion

            //-----------------------------------Vedio 02-----------------------------------
            #region Linear Search
            //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int result = Helper.LinearSearch(arr, 50);
            //Console.WriteLine(result);

            //Point[] points =
            //{
            //    new Point(1, 2),
            //    new Point(10, 20),
            //    new Point(100, 200),
            //    new Point(1000, 2000)
            //};
            //Point point = new Point(10, 20);
            //int result = Helper<Point>.LinearSearch(points, point);

            ////Console.WriteLine(points[0] == points[1]);
            //Console.WriteLine(result);
            //Employee E01 = new Employee(10, "Mona", 9000);
            //Employee E02 = new Employee(20, "Amr", 4000);

            //if (E01.Equals(E02))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals");

            //Employee[] employees =
            //{
            //    new Employee(10, "Amr", 4000),
            //    new Employee(20, "May", 9000),
            //    new Employee(30, "Mona", 3000),
            //    new Employee(40, "Omar", 2000),
            //    new Employee(50, "Ahmed", 10000),
            //};

            //Employee employee = new Employee(20, "May", 9000);

            //int result = Helper<Employee>.LinearSearch(employees, employee);
            //Console.WriteLine(result);

            #endregion

            #region Equals & GetHashCode
            //-----------------------------------Vedio 03-----------------------------------
            //string name01 = "Route";
            //string name02 = "Route";

            //Console.WriteLine(name01.Equals(name02));

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            //Employee E01 = new Employee(10, "Mona", 9000);
            //Employee E02 = new Employee(20, "Amr", 4000);

            //if (E01.Equals(E02))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals");

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //-----------------------------------Vedio 04-----------------------------------


            //-----------------------------------Vedio 06-----------------------------------
            //Employee[] employees =
            //{
            //    new Employee(10, "Amr", 4000),
            //    new Employee(20, "May", 9000),
            //    new Employee(30, "Mona", 3000),
            //    new Employee(40, "Omar", 2000),
            //    new Employee(50, "Ahmed", 10000),
            //};

            //Employee employee = new Employee(20, "May", 9000);

            //int result = Helper<Employee>.LinearSearch(employees, employee , new EmployeeNameEqualityComparer());
            //Console.WriteLine(result);

            //int result1 = Helper<Employee>.LinearSearch(employees, employee , new EmployeeIdEqualityComparer());
            //Console.WriteLine(result1); 

            #endregion

            //-----------------------------------Vedio 07-----------------------------------
            #region Bubble Sort
            //int[] numbers = { 8, 4, 9, 7, 6, 10, 5, 3, 1, 2 };
            //Helper<int>.BubbleSort(numbers);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Employee[] employees =
            //{
            //    new Employee(10, "Amr", 4000),
            //    new Employee(20, "May", 9000),
            //    new Employee(30, "Mona", 3000),
            //    new Employee(40, "Omar", 2000),
            //    new Employee(50, "Ahmed", 10000),
            //};

            //Helper<Employee>.BubbleSort(employees);

            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion
        }

    }
}
