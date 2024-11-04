using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.OpenClosePrinciple
{
    public abstract class NoOpenClose
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }

        public NoOpenClose(string name, string description, int salary)
        {
            Name = name;
            Description = description;
            Salary = salary;
        }

        public int calculateBonus()
        {
            return 200 * Salary;
            /*
             * Let say our requirements changes for caclualte bonus w.r.t employee type then we have
             * to modify this function so this will voilate the principle as it is not close for modification
             */
        }
    }
}
