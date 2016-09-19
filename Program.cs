using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesSlide22
{
    class Program
    {
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
            if (animals.ContainsKey("Dragon"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }           
        }
    }
}
