using System;
using System.Collections.Generic;
using System.Text;

namespace Employeetask
{
    internal class Employee:Human
    {
        public Employee(string fullname, byte age): base(fullname,  age)
        { 
        
        }
        public Employee(string fullname, byte age, double salary, string position) : base( fullname,  age)
        { 
         Salary= salary;
            Position= position; 
        }

        public double Salary;
        public string Position;
        public string Getinfo()
        {
            return $" Fullname :{Fullname}- Age : {Age}- Salary: {Salary} Position : {Position}";
        }
    }
}
