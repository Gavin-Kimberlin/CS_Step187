using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step187
{
    class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator ==(Employee x, Employee y)
        {
            if (x.Id == y.Id)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee x, Employee y)
        {
            if (x.Id != y.Id)
                return true;
            else
                return false;
        }
    }
}
