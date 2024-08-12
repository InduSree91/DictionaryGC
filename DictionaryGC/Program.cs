// Dictionary stores the data in key value pair and also it stores same type of data in a collection

// Dictionary<TKey, TValue>

// Keys returns the collection of keys in the dictionary<Tkey, TValue>

// Values returns the collection of Values in the dictionary<Tkey, TValue>

// In dictionary key can not be null, value can be null

// If we insert null for key there will be no compilation error, we will get run time error

// Keys should be unique in the dictionary


using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DictionaryGC
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> StudentAge = new Dictionary<string, int>();

            StudentAge.Add("Indu", 21);
            StudentAge.Add("Ram", 32);
            StudentAge.Add("Sai", 27);

            //Console.WriteLine(StudentAge.ContainsValue(27));

            //Console.WriteLine(StudentAge.ContainsKey("Indu"));

            int value;

            //StudentAge.TryGetValue("Sai", out value);

            //Console.WriteLine(value);

            if (StudentAge.TryGetValue("Ravi", out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }

            ////Console.WriteLine(StudentAge["Sai"]);

                ////foreach (var item in StudentAge) // in place of var we can use KeyValuePair<TKey, TValue>
                ////{
                ////    Console.WriteLine("Key is : " + item.Key + ", Value is : " + item.Value);
                ////}

                //foreach(string key in StudentAge.Keys)
                //{
                //    Console.WriteLine(key); // To print the keys
                //}

                //Console.WriteLine("----------------------");

                //foreach(int value in StudentAge.Values)
                //{
                //    Console.WriteLine(value); // To print the values
                //}

                //Console.WriteLine("----------------------");

                //Console.WriteLine(StudentAge.Count());

                //Employee emp1 = new Employee()
                //{
                //    name = "Sai",
                //    designation = "Developer",
                //    age = 27,
                //    id = 09,
                //};

                //Employee emp2 = new Employee()
                //{
                //    name = "Ram",
                //    designation = "Designer",
                //    age = 23,
                //    id = 18,
                //};

                //Employee emp3 = new Employee()
                //{
                //    name = "Shayam",
                //    designation = "HR",
                //    age = 35,
                //    id = 45,
                //};


                //Dictionary<int, Employee> myEmployee = new Dictionary<int, Employee>();

                //myEmployee.Add(emp1.id, emp1);
                //myEmployee.Add(emp2.id, emp2);
                //myEmployee.Add(emp3.id, emp3);

                //Console.WriteLine(myEmployee.ContainsKey(45));

                //if (myEmployee.ContainsKey(4))
                //{
                //    Console.WriteLine("Key Found");
                //}
                //else
                //{
                //    Console.WriteLine("Key Not Found");
                //}




                //myEmployee.Remove(emp2.id);

                //Console.WriteLine(myEmployee.Count(emp => emp.Value.name.StartsWith("R"))); // Gives the number of occurences that satisfy the specified condition
        }
    }
}