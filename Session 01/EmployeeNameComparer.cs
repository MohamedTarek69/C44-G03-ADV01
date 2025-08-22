using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class EmployeeNameComparer : IComparer<Employee>
    {
        // X = Ahmed
        // Y = Null
        public int Compare(Employee? x, Employee? y)
        {
            //if (x is null || y is null) return -1;
            //else if (y is null) return 1;
            //else return x.Name.CompareTo(y.Name);
            return x?.Name?.CompareTo(y?.Name) ?? -1;
        }
    }
}
