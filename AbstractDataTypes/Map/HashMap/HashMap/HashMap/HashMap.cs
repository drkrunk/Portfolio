using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    class HashMap
    {
        private Bucket[] buckets;
 
        public HashMap() {
            setUpBuckets(31);
        }

        public HashMap(int size) {
            setUpBuckets(size);
        }

        public void Add(string key, IComparable value) {
            int hashKeyCode = SimpleStringHashFunction(key);
            buckets[hashKeyCode].Add(value);
        }

        public void Remove(string key, IComparable value){
            int hashKeyCode = SimpleStringHashFunction(key);
            buckets[hashKeyCode].Remove(value);
        }

        public IComparable Find(string stringKey, IComparable value) {
            int key = SimpleStringHashFunction(stringKey);
            return buckets[key].Find(value);
        }


        public IComparable[] FindAll(string stringKey){
            int key = SimpleStringHashFunction(stringKey);
            return buckets[key].ToArray();
        }

        /*
         Could be better by string folding but adding the acsii of the key
         is good enough for this example.
        */
        private int SimpleStringHashFunction(string hashString) {
            int hashKey = 0;
            for (int i = 0; i < hashString.Length; i++){
                int charCode = hashString[i];
                hashKey = (hashKey * 27 + charCode) % buckets.Length;
            }

            return hashKey;
        }


        public void Print() {
            for (int i = 0; i < buckets.Length; i++)
            {
                Console.Write("Bucket" + i  + ": |");
                buckets[i].Print();

                if (buckets[i].Empty)
                    Console.Write("EMPTY|");

                Console.WriteLine("");
            }

            
        }


        private void setUpBuckets(int capacity) {
            buckets = new Bucket[getNextPrime(capacity)];

            for (int i = 0; i < buckets.Length; i++)
                buckets[i] = new Bucket();
        }


        //There are less collisions with an array size of a primary number.
        private int getNextPrime(int minNumber) {
            while (!isPrime(minNumber)) minNumber++;

            return minNumber;
        }

        private bool isPrime(int number) {
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
                if (number % i == 0)
                    return false;
            
            return true;
        }
    }
}
