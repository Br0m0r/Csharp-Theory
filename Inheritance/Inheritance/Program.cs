namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Bromor";
            Employee employee = new Employee();
            employee.EmployeeNumber = 1;
            employee.FirstName = "Bromor";
            string name = employee.GetFullName();

            Doctor doctor = new Doctor();
            doctor.FirstName = "name";
            doctor.EmployeeNumber = 2;
            doctor.speciality = "Surgeon";
        }
    }
}