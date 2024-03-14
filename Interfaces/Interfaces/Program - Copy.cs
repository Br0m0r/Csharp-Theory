﻿namespace Interfaces
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bromor","Plays",99);
            employee.FirstName = "Bromor";
            employee.LastName = "Plays";
            employee.EmployeeNumber = 99;

            IPerson person = employee;
            Console.WriteLine(person.GetDescription());
            employee.GetFullName();
            person.GetDescription();

            Doctor doctor  = new Doctor("Doc","Oc",1,"dentist");
           
            

            IPerson person2 = doctor;
            Console.WriteLine(person2.GetDescription());
            

            Console.ReadLine();
        }

    }




}