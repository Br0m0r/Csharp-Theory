﻿namespace Abstraction
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Bromor";
            employee.LastName = "Plays";
            employee.EmployeeNumber = 99;

            Person person = employee;
            Console.WriteLine(person.GetDescription());
            employee.GetFullName();
            person.GetDescription();

            Doctor doctor  = new Doctor();
            doctor.FirstName = "House";
            doctor.LastName = "Greg";
            doctor.EmployeeNumber = 10;
            doctor.Speciality = "Neurosurgeon";

            Person person2 = doctor;
            Console.WriteLine(person2.GetDescription());
            

            Console.ReadLine();
        }

    }




}