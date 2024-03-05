namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "PersonName";

            Visitor visitor = new Visitor();
            visitor.FirstName = "Visitor";

            Patient patient = new Patient();
            patient.FirstName = "Patient";
            patient.Location = "ICU";

            Doctor doctor = new Doctor();
            doctor.EmployeeNumber = 1;
            doctor.FirstName = "House";
            doctor.Speciality = "Diagnostician";

            Nurse nurse = new Nurse();
            nurse.FirstName = "NurseName";
            nurse.Qualification = "RN";
            nurse.EmployeeNumber = 2;

            Custodian custodian = new Custodian();
            custodian.EmployeeNumber = 3;
            custodian.FirstName = "CustodianName";
            
            Employee softWareEngineer = new Employee();
            softWareEngineer.EmployeeNumber = 4;
            softWareEngineer.FirstName = "Bromor";


            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(visitor); 
            people.Add(patient);
            people.Add(softWareEngineer);
            people.Add(doctor);
            people.Add(custodian);
            people.Add(nurse);

            foreach (Person myPerson in people)
            {
                PrintName(myPerson);
            }


            List<Employee> employees = new List<Employee> {softWareEngineer, doctor,custodian, nurse};

            List<Doctor> doctors = new List<Doctor> { doctor };
           
            Console.ReadLine();
                 

        }


        private static void PrintName(Person person)
        {
            Console.WriteLine(person.GetFullName());
        }

    }
}