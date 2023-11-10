using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8_OOP_Generci_Collections
{
    public enum Gender
    {
        Male,
        Female,
    }


    internal class Employee
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, Gender gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;

        }

        public void PrintInfo()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine($"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Gender: {Gender}\n" +
                $"Salary: {Salary}");
        }
    }
}
