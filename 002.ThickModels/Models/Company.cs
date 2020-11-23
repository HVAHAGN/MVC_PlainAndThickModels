using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001.PlainModels.Models
{
    public class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }

        public Company(string name, int employees)
        {
            Name = name;
            Employees = employees;
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Employees: {Employees}";
        }
    }
}
