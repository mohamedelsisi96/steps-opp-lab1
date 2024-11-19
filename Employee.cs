using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opplab1
{
    internal class Employee
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        private int _salary;
        private string? _phone;
        public string? Address { get; set; }
        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 6000)
                {
                    _salary = 6000;
                }
                else
                {
                    _salary = value;
                }
            }
        }
        public string? Phone
        {
            get { return _phone; }
            set
            {
                if (value != null && value.Length == 11 && (value.StartsWith("010") || value.StartsWith("011") || value.StartsWith("012") || value.StartsWith("015")))
                {
                    _phone = value;
                }
                else
                {
                    Console.WriteLine("please enter valide phone number ");
                }
            }
        }
        public void IncreaseSalary(int bounes)
        {
            _salary += bounes;
        }
        public void Display()
        {
            Console.WriteLine($"the name of employee is {Name??"Not Set"} \n the Id of employee is {Id } \n the salary of employee is {_salary} \n the phone of employee is {_phone ?? "Not Set"} \n the address of employee is {Address ?? "Not Set"}  ");
        }
    }
}
