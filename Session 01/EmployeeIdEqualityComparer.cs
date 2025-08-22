using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class EmployeeIdEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (x is not null && y is not null)
            {
                return x.Id == y.Id;
            }
            else
            {
                return false;
            }
        }
        public int GetHashCode(Employee? obj)
        {
            return HashCode.Combine(obj.Id);
        }
    }
}
