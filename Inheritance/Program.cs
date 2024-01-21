﻿using System.Net.Http.Headers;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<PayrollEmployee> payrollEmployees = new List<PayrollEmployee>();
            List<ContractEmployee> contractEmployees = new List<ContractEmployee>();

            Employee employee1 = null;
            bool flag = true;
            while (flag)
            {
                
                Console.WriteLine("Enter choice 1: Add Employee 2: Display All Employees 3. Exit ");
                byte c = byte.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:

                        Console.WriteLine("Which employee do you want to add ? 1: payroll employee 2 : Contract Employee");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            employee1 = new PayrollEmployee();
                            payrollEmployees.Add((PayrollEmployee)employee1);
                            employees.Add((PayrollEmployee)employee1);

                        }
                        else if (choice == 2)
                        {
                            employee1 = new ContractEmployee();
                            contractEmployees.Add((ContractEmployee)employee1);
                            employees.Add((ContractEmployee)employee1);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Employees in Payroll :");
                        foreach(var employee in payrollEmployees)
                        {
                            employee.DisplayDetails();
                        }
                        Console.WriteLine("Employees in Contract :");
                        foreach (var employee in contractEmployees)
                        {
                            employee.DisplayDetails();
                        }
                        Console.WriteLine("All Employees:");
                        foreach (var employee in employees)
                        {
                            employee.DisplayDetails();
                        }
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
        
    }
}