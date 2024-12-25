using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class Appartment
    {
        public string Name { get; set; }
        private int age;
        public string Nat {  get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 17)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("The age is invalid! :(");
                }
            }
        }

        public Appartment(int age, string name, string nat)
        {
            Age = age;
            Name = name;
            Nat = nat;
        }

        public void Info()
        {
            Console.WriteLine($"This is info of person: {Name}, he have {Age} years and he was born in {Nat}");
        }
    }
}
