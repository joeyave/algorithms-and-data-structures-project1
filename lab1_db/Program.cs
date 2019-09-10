using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_db
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\josep\source\repos\lab1_db\lab1_db\DB.txt");

            Employee[] employees = new Employee[lines.Length];

            for(int i = 0; i < lines.Length; i++)
            {
                employees[i] = new Employee(lines[i]);
            }

            for(int i = 0; i < employees.Length; i++)
            {
                for(int j = i + 1; j < employees.Length; j++)
                {
                    if(employees[i].Ssn > employees[j].Ssn)
                    {
                        int temp = employees[i].Ssn;
                        employees[i].Ssn = employees[j].Ssn;
                        employees[j].Ssn = temp;
                    }
                }
            }

            foreach (Employee employee in employees)
            {
                if(employee.IsFired == false)
                    Console.WriteLine(employee);
            }

            Console.ReadLine();
        }
    }
}
