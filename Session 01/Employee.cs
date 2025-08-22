using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public static bool operator ==(Employee left, Employee right)
        {
            //return (left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary);
            return left.Equals(right);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            //return (left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary);
            //return !left.Equals(right);
            return !(left == right);
        }
        
        public override bool Equals(object? obj)
        {
            #region UnSafe Way Using Explicit Casting
            //Employee? emp = (Employee?)obj;
            //if (emp is not null)
            //{
            //    return (this.Id == emp.Id) && (this.Name == emp.Name) && (this.Salary == emp.Salary);
            //}
            //else
            //{
            //    return false;
            //} 
            #endregion

            #region Safe Way Using Is Operator
            //if (obj is Employee emp)
            //{
            //    return (this.Id == emp.Id) && (this.Name == emp.Name) && (this.Salary == emp.Salary);
            //}
            //else
            //{
            //    return false;
            //} 
            #endregion

            #region Safe Way Using As Operator
            Employee? employee = obj as Employee;
            if (employee is not null)
            {
                return (this.Id == employee.Id) && (this.Name == employee.Name) && (this.Salary == employee.Salary);
            }
            else
            {
                return false;
            } 
            #endregion

        }

        public override int GetHashCode()
        {
            // 10, 1000, 5 => 1015
            // 5, 1000, 10 => 1015
             //return Id.GetHashCode() + (Name?.GetHashCode() ?? 0) + Salary.GetHashCode();
            return HashCode.Combine(Id, Name, Salary);
        }
    }
}
