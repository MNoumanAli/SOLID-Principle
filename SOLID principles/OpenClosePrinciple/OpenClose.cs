using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.OpenClosePrinciple
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string description, int salary)
        {
            Name = name;
            Description = description;
            Salary = salary;
        }

        public abstract int calculateBonus();
    };

    public class PermanentEmployee : Employee
    {
        public int Bonus { get; set; }
        public PermanentEmployee(string name, string description, int salary, int bonus) : base( name, description, salary)
        {
            Bonus = bonus;
        }
        public override int calculateBonus()
        {
            return Bonus * Salary;
        }
    }

}
