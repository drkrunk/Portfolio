using System;
using System.Collections.Generic;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args){
            HashMap hm = GenerateHashMap();

            string input = "";
            while (input != "/exit") {
                input = Console.ReadLine();

                Person p = ((hm.Find(input, input) as Person));
                if (p != null){
                    p.Print();
                    Console.WriteLine();
                }
                else{ 
                    Console.WriteLine("Person not found!\n"); 
                }
            }

        }

        
        private static HashMap GenerateHashMap() {
            HashMap map = new HashMap(32);

            for (int i = 0; i < 32; i++){
                Person p = Person.Generate();
                map.Add(p.Name, p);
            }


            map.Print();
            Console.WriteLine();
            return map;

        }
    }
}
