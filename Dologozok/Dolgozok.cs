using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dologozok
{
    internal class Dolgozok
    {
        private int id;
        private string name;
        private string gender;
        private int age;
        private int salary;

        public int ID
        {
            get 
            {
                return id; 
            }
            set
            {
                if(value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }
            }
        }

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }

        public Dolgozok(int id, string name, string gender, int age, int salary)
        {
            //we only need to check the ints
            ID = id;
            Name = name;
            Gender = gender;
            Age = age;
            Salary = salary;
        }
    }
}
