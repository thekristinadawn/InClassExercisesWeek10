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
            //create dictionary

            Dictionary<String, List<string>> inventory = new Dictionary<string, List<string>>();

            List<string> list1 = new List<string>();
            list1.Add("500");

            List<string> list2 = new List<string>();
            list2.Add("seashell"); list2.Add("strange berry"); list2.Add("lint");

            inventory["gold"] = list1;
            inventory["pouch"] = list2;

            foreach (string key in inventory.Keys)
            {
                foreach (string value in inventory[key])
                {
                    Console.WriteLine(value);
                }
            }

        }
    }
}
