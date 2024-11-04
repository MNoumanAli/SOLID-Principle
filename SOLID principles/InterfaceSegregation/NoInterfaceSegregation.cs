using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.InterfaceSegregation
{
    public interface IEmployee
    {
        public bool login(string username, string password);
        public bool register(string username, string email, string password);
        public void sendEmail();
        public void logger();
    }
}
