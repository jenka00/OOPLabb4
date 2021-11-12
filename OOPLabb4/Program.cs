using System;
using System.Collections.Generic;

namespace OOPLabb4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 - Stack

            //Objects of Employee class
            Employee E1 = new Employee { ID = 104, Name = "Sara", Gender = "Female", Salary = 40000 };
            Employee E2 = new Employee { ID = 101, Name = "Anas", Gender = "Male", Salary = 20000 };
            Employee E3 = new Employee { ID = 103, Name = "Tobias", Gender = "Male", Salary = 45000 };
            Employee E4 = new Employee { ID = 102, Name = "Hanna", Gender = "Female", Salary = 30000 };
            Employee E5 = new Employee { ID = 105, Name = "Anna", Gender = "Female", Salary = 50000 };

            //Stack list for objects in Employee class
            Stack<Employee> employees = new Stack<Employee>();

            employees.Push(E1);
            employees.Push(E2);
            employees.Push(E3);
            employees.Push(E4);
            employees.Push(E5);

            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.ID} {e.Name} {e.Gender} {e.Salary}");
                
                Console.WriteLine("Items left in the stack = " + employees.Count);
            }

            Console.WriteLine("--------------------------------------------------------------------");

            //Retrive from stack using Pop Method
            Employee employeeStack1 = employees.Pop();

            Console.WriteLine($"{employeeStack1.ID} {employeeStack1.Name} {employeeStack1.Gender} {employeeStack1.Salary}");
            
            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeeStack2 = employees.Pop();

            Console.WriteLine($"{employeeStack2.ID} {employeeStack2.Name} {employeeStack2.Gender} {employeeStack2.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeeStack3 = employees.Pop();

            Console.WriteLine($"{employeeStack3.ID} {employeeStack3.Name} {employeeStack3.Gender} {employeeStack3.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeeStack4 = employees.Pop();

            Console.WriteLine($"{employeeStack4.ID} {employeeStack4.Name} {employeeStack4.Gender} {employeeStack4.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeeStack5 = employees.Pop();

            Console.WriteLine($"{employeeStack5.ID} {employeeStack5.Name} {employeeStack5.Gender} {employeeStack5.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Console.WriteLine("--------------------------------------------------------------------");

            //Pushes all objects back to stack
            employees.Push(E1);
            employees.Push(E2);
            employees.Push(E3);
            employees.Push(E4);
            employees.Push(E5);

            //Retrives from stack using Peek Method
            Employee employeePeek1 = employees.Peek();

            Console.WriteLine($"{employeePeek1.ID} {employeePeek1.Name} {employeePeek1.Gender} {employeePeek1.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeePeek2 = employees.Peek();

            Console.WriteLine($"{employeePeek2.ID} {employeePeek2.Name} {employeePeek2.Gender} {employeePeek2.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeePeek3 = employees.Peek();

            Console.WriteLine($"{employeePeek3.ID} {employeePeek3.Name} {employeePeek3.Gender} {employeePeek3.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeePeek4 = employees.Peek();

            Console.WriteLine($"{employeePeek4.ID} {employeePeek4.Name} {employeePeek4.Gender} {employeePeek4.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Employee employeePeek5 = employees.Peek();

            Console.WriteLine($"{employeePeek5.ID} {employeePeek5.Name} {employeePeek5.Gender} {employeePeek5.Salary}");

            Console.WriteLine("Items left in the stack = " + employees.Count);

            Console.WriteLine("--------------------------------------------------------------------");

            //Checks if item 3 is in stack
            if (employees.Contains(employeeStack3))
            {
                Console.WriteLine($"Is is in stack.");
            }
            else
            {
                Console.WriteLine($"Is not in stack.");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            //Part 2 - List

            //List from Employee class with 5 objects
            List<Employee> employList = new List<Employee>();

            employList.Add(E1);
            employList.Add(E2);
            employList.Add(E3);
            employList.Add(E4);
            employList.Add(E5);

            //Using Contain method to check if the list contains item E2
            if (employList.Contains(E2))
            {
                Console.WriteLine($"Employee 2 is in the list.");
            }
            else
            {
                Console.WriteLine($"Employee 2 does not exist in the list.");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            //Using Find method to find the first item who is "male"

            Employee emp = employList.Find(e => e.Gender == "Male");

            Console.WriteLine($"{emp.ID} {emp.Name} {emp.Gender} {emp.Salary}");

            Console.WriteLine("--------------------------------------------------------------------");

            //Using FindAll method to find all the items who are "male"

            List<Employee> allMale = employList.FindAll(f => f.Gender == "Male");

            foreach  (Employee male in allMale)
            {
                Console.WriteLine($"{male.ID} {male.Name} {male.Gender} {male.Salary}");
            }
        }
    }
}
