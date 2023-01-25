using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyApp
{
    class TestLambda
    {
        static public void test()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { SSN = 1, Name = "james", Address = "island", Age = 21 });    
            list.Add(new Person() { SSN = 2, Name = "jake", Address = "NY", Age = 20 });    
            list.Add(new Person() { SSN = 3, Name = "John", Address = "Banglore", Age = 20 });    
            list.Add(new Person() { SSN = 3, Name = "Johny", Address = "Dehradun", Age = 16 });    

            /*foreach(Person person in list)
            {
                Console.WriteLine(person.ToString());
            }*/

            
            GetTeenagers(list);
            CheckName(list, "John");
        }
        //uc2
        static void Top2withAgeless60(List<Person> list)
        {
            var result = list.FindAll(x => x.Age < 60).Take(2);
            foreach (var p in result) Console.WriteLine(p.ToString());
        }

        static void GetTeenagers(List<Person> list)
        {
            var result = list.FindAll(x => x.Age >=13 && x.Age<18).Take(2);
            foreach (var p in result) Console.WriteLine(p.ToString());
        }

        static void PrintAverageAge(List<Person> list)
        {
            Console.WriteLine("Average age is "+list.Average(x=>x.Age));
        }

        static void CheckName(List<Person> list,string name)
        {
            Console.WriteLine($"{name} exists? : "+list.Exists(x => x.Name == name)); 
        }

    }

    [Serializable]
    public class Person
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address{get;set;}
        public int Age { get; set; }

        public Person()
        {
        }

        public Person(int sSN, string name, string address, int age)
        {
            SSN = sSN;
            Name = name;
            Address = address;
            Age = age;
        }

        public override string ToString()
        {
            return nameof(SSN) + ":" + SSN + " " + nameof(Name) + ":" + Name + " " + nameof(Address) + ":" + Address +" "+ nameof(Age) + ":" + Age;
        }
    }
}
