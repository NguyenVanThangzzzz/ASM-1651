using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    internal abstract class Employee
    {
        private string name;
        private int age;
        private string position;

        public Employee(string name, int age, string position)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
        }
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Ten tren 5 chu may`");

                }
                name = value; 
            }
        }
        public int Age
        {

            get { return age; }
            set {
                if (value < 18)
                {
                    throw new ArgumentException("TUoi phai tren 18");

                }
                age = value; 
            }
        }
        public string Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        public abstract void DisplayInfo();


    }
}
