using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class EmployeeAgeComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Age.CompareTo(y?.Age) ?? -1;
        }
    }
}
