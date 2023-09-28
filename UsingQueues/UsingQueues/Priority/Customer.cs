using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.Priority
{
    public enum Level
    {
        Gold = 3,
        Platinum = 1,
        Silver = 2 
    }
    public class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Customer(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string? ToString() => $"[{Firstname} {Lastname}]";
    }
}
