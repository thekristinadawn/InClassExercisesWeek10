using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExercisesWeek10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //create dictionary - string/list
            Dictionary<String, List<string>> inventory = new Dictionary<string, List<string>>();

            List<string> list1 = new List<string>();
            list1.Add("500");

            List<string> list2 = new List<string>();
            list2.Add("flint"); list2.Add("twine"); list2.Add("gemstone");

            List<string> list3 = new List<string>();
            list3.Add("xylophone"); list3.Add("dagger"); list3.Add("bedroll"); list3.Add("bread loaf");

            inventory["gold"] = list1;
            inventory["pouch"] = list2;
            inventory["backpack"] = list3;

            //add in dictionary
            List<string> list4 = new List<string>();
            list4.Add("seashell"); list4.Add("strange berry"); list4.Add("lint");
            inventory.Add("pocket", list4);

            //sort from list
            list3.Sort();
            //remove from list
            list3.Remove("dagger");

            //change gold value to 550 in LIST
            list1[0] = "550";


            foreach (string key in inventory.Keys)
            {
                foreach (string value in inventory[key])
                {
                    Console.WriteLine(value);
                }
            };


            //Exercise 2
            //create dictionary - string/dictionary {string,int}
            Dictionary<string, Dictionary<string, double>> produce =
            new Dictionary<string, Dictionary<string, double>>
            {
                {
                    "banana",
                    new Dictionary<string, double>
                    {
                        {"price", 4},
                        {"stock", 2}
                    }
                },
                {
                    "apple",
                    new Dictionary<string, double>
                    {
                        {"price", 2},
                        {"stock", 0}
                    }
                },
                    {
                    "orange",
                    new Dictionary<string, double>
                    {
                        {"price", 1.5},
                        {"stock", 5}
                    }
                },
                    {
                    "pear",
                    new Dictionary<string, double>
                    {
                        {"price", 3},
                        {"stock", 8}
                    }
                }
            };

            //loop and print keys and values (nested dictionary)
            foreach (var pair in produce)
            {
                foreach (var innerPair in pair.Value)
                {
                    Console.WriteLine("{0}:{1},{2}", pair.Key, innerPair.Key, innerPair.Value);
                }
            }

            //prints keys
            //foreach (var item in produce)
            //{
            //string key = item.Key;
            // Dictionary<string, double> innerDict = item.Value;
            //Console.WriteLine(key,innerDict + key,item.Value);

            //}

            //calculate total if all items sold

            foreach (var pair in produce)
            {
                foreach (var innerPair in pair.Value)
                {
                    Console.WriteLine("{0}:{1},{2}", pair.Key, innerPair.Key, innerPair.Value);
                }
            }

        }
    }
}


//Ctrl + F5 for command box 