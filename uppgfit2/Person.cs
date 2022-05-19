using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgfit2
{
    public class Person
    {

        public string Name { get;}
        public int Age { get; }
        public int Price { get; }
        public string ReturnPersonDetails;


        public Person(string name, int age, int price)
        {
            this.Name = name;
            this.Age = age;
            this.Price = price;

        }
    }
             
}
