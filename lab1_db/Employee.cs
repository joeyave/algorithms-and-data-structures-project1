using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_db
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public char Sex { get; set; }
        public int Ssn { get; set; }
        public bool IsFired { get; set; } = false;
        
        public Employee(string input)
        {
            string[] data = input.Split();

            Name = data[0];
            Surname = data[1];
            Birthday = Convert.ToDateTime(data[2]);
            Sex = Convert.ToChar(data[3]);
            Ssn = Convert.ToInt32(data[4]);
            if(data[5] != null && data[5] == "fired")
                IsFired = true;
        }

        public Employee() { }

        public override string ToString()
        {
            return $"[{Name} {Surname}, {Birthday.ToShortDateString()}, {Sex}, {Ssn}, {IsFired}]";
        }
    }
}
