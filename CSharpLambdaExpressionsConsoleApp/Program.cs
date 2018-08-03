using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLambdaExpressionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empOne = new Employee { Id = 0, firstName = "Stephen", lastName = "Stephenson" };
            Employee empTwo = new Employee { Id = 1, firstName = "Jesse", lastName = "Smith" };
            Employee empThree = new Employee { Id = 2, firstName = "Joe", lastName = "Larkin" };
            Employee empFour = new Employee { Id = 3, firstName = "Carolyn", lastName = "Baker" };
            Employee empFive = new Employee { Id = 4, firstName = "Joe", lastName = "Thompsen" };
            Employee empSix = new Employee { Id = 5, firstName = "Kim", lastName = "Kardashian" };
            Employee empSeven = new Employee { Id = 6, firstName = "Tom", lastName = "Cruise" };
            Employee empEight = new Employee { Id = 7, firstName = "Mary", lastName = "Magdalene" };
            Employee empNine = new Employee { Id = 8, firstName = "Joe", lastName = "Smith" };
            Employee empTen = new Employee { Id = 9, firstName = "Tara", lastName = "Reid" };

            List<Employee> employees = new List<Employee>() { empOne, empTwo, empThree, empFour, empFive, empSix, empSeven, empEight, empNine, empTen };

            List<Employee> thoseMatchingJoe = new List<Employee>();
            foreach (Employee match in employees)
            {
                if (match.firstName == "Joe")
                {
                    thoseMatchingJoe.Add(match);
                }
            }




            List<Employee> thoseMatchingJoeLambda = new List<Employee>();
            thoseMatchingJoeLambda = employees.Where(x => x.firstName == "Joe").ToList();

            List<Employee> thoseEmpIdGreaterThanFive = new List<Employee>();
            thoseEmpIdGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("Welcome to the \"Lambda\" Demonstration Application!" + Environment.NewLine);
            Console.WriteLine("Even though you might not be able to see it here, we are building a few lists." + Environment.NewLine + "Firstly using a tradional \"for each\" loop and then two others using Lambda Expressions!");
            Console.WriteLine(Environment.NewLine + "Total Employees: " + employees.Count);
            Console.WriteLine("Total Employees Named \"Joe\": " + thoseMatchingJoe.Count);
            Console.WriteLine("Total Employees With An ID Number Greater Than 5: " + thoseEmpIdGreaterThanFive.Count);

            Console.WriteLine(Environment.NewLine + "Thank you for demoing my application! Press enter to exit!");
            Console.ReadLine();

        }
    }
}