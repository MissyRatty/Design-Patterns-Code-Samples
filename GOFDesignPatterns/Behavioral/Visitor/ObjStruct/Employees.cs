using System;
using System.Collections.Generic;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    //This is the object structure class
    public class Employees
    {
        private readonly List<Staff> _employees = new List<Staff>();

        public void AddEmployee(Staff employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(Staff employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Staff employee in _employees)
            {
                employee.Accept(visitor);
            }

            Console.WriteLine();
        }
    }
}
