using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    //Class used for testing, nothing to see here.
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is string)
                return Name.CompareTo(obj);

            if (obj is int)
                return Age.CompareTo(obj);

            if (obj is Person)
                return Name.CompareTo(((Person)obj).Name);
            
            return -1;
        }

        public override string ToString()
        {
            return Name;
        }

        public void Print()
        {

            Console.WriteLine("Name: " + Name + " , Age: " + Age);
        }


        public static Person Generate()
        {

            string[] firstNames = { "Vinnie", "Nanci", "Bernardina", "Leroy", "Ty", "Don", "Stephen", "Soila", "Haydee", "Katherine" };
            string[] lastNames = { "Dudley", "Heath", "Rojas", "Bullock", "Ellison", "Blackwell", "Massey", "Tyler", "Hurley", "Lewis" };

            Random rand = new Random();

            Person person = new Person();

            person.Name = lastNames[rand.Next(lastNames.Length)] + " " + firstNames[rand.Next(firstNames.Length)];
            person.Age = rand.Next(18, 90);

            return person;

        }

    }
}
