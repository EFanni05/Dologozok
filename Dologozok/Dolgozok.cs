using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        [JsonPropertyName("id")]
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

        [JsonPropertyName("age")]
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

        [JsonPropertyName("salary")]
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

        [JsonPropertyName("name")]
        public string Name { get => name; set => name = value; }
        [JsonPropertyName("gender")]
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
