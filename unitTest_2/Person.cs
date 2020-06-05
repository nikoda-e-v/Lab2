using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace unitTest_2
{
   public class Person
    {
         string name;
         string surname;
         int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Person()
        {
        }

        public  override bool Equals(object obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   surname == person.surname &&
                   age == person.age;
        }


        public static string ToJson(Person thisPerson)
        {
            return JsonSerializer.Serialize(thisPerson);
        }


        public static  Person FromJSON(string json)
        {
            Person person = JsonSerializer.Deserialize<Person>(json);
            return person;
        }
    }
}
