﻿  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step187
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Gavin";
            employee1.LastName = "Kimberlin";
            employee1.SayName();

            Employee employee2 = new Employee();
            employee2.FirstName = "Michael";
            employee2.LastName = "Keaton";
            employee2.SayName();

            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadLine();
        }
    }
}
