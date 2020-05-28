using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company AAA = new Company()
            {
                Name = "AAA",
            };

            Employee Joe = new Employee()
            {
                Firstname = "Joe",
                Lastname = "Blo",
                Title = "Programmer"
            };
            AAA.employees.Add(Joe);

            Employee John = new Employee()
            {
                Firstname = "John",
                Lastname = "Doe",
                Title = "Developer"
            };
            AAA.employees.Add(John);

            Employee Jane = new Employee()
            {
                Firstname = "Jane",
                Lastname = "Doe",
                Title = "Programmer1"
            };
            AAA.employees.Add(Jane);

            foreach (Employee emp in AAA.employees)
            {
                Console.WriteLine($"{emp.Firstname} {emp.Lastname} is a {emp.Title}");
            }

            // Iterate the company's employee list and generate the
            // simple report shown above

        }
    }
}