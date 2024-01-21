using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ContractEmployee : Employee
    {
        public DateOnly ContractDate { get; set; }

        public float Duration { get; set; }

        public double Charges { get; set; }

        public ContractEmployee() : base()
        {
            Console.WriteLine("Enter ContractDate in DD/MM/YYYY:");
            this.ContractDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Duration");
            this.Duration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Charges");
            this.Charges = double.Parse(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"id : {this.Id}");
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Manager : {this.Manager}");
            Console.WriteLine($"Contract Date : {this.ContractDate}");
            Console.WriteLine($"Duration : {this.Duration}");
            Console.WriteLine($"Charges : {this.Charges}");
        }
    }
}
