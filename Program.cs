using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesSlide22
{
    class Program
    {
        private static object legs;

        public static bool Bear { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            
            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Dog", 4);
            animals.Add("Human", 2);
            animals.Add("Marsupial", 2);

            //A true statement
            if (animals.ContainsKey("Bear"))
            {
                Console.WriteLine(true);
            }

            //An animal that is not in our dictionary.  Added else for false otherwise nothing prints. 
            //Could be more efficient by adding animals that aren't in the dictionary. 
            if (animals.ContainsKey("Dragon"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //New Query
            
            if (animals.ContainsKey("Bear"))
            {
                int value = animals["Bear"];
                Console.WriteLine("A Bear has " + value + " legs.");
            }
        }
    }
}
