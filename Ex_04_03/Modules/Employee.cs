using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_04_03.Modules
{
    public class Employee : Object
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public Employee(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

        public override string ToString()
        {
            return "Employee[ id="+this.Id+" , name="+this.Name+" , address="+this.Address+"]";
        }
    }
}