using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.InterfaceSegregation.ISP
{
    public interface IEmployee
    {
        public bool login(string username, string password);
        public bool register(string username, string email, string password);
    }
}
