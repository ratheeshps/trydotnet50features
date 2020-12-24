using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trydotnet50features.Models
{
    public class EmployeeModel
    {
        //Init setter - helps to make the class immutable, get rid of boiler plate codes
        public string Name { get; init; }
        public string Department { get; init; }
        public string Designation { get; init; }
    }

    //Immutable and make like a value
    // Can inherit also
    public record EmployeeRecord(string Name, string Department,string Designation)
    {
        public string Salary => Department == "New Initiatives" ? "10,000 AED" : "8,000 AED";
    }

    public record Person
    {
      public string name { get; init; }
        public string age { get; init; }
    }

    public record SalesPerson : Person
    {
        public string Designation { get; init; }
    }
}

