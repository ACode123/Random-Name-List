using System;
using System.Collections.Generic;

namespace NamePicker
{
    //wrote this program list the names of everyone in my class in a
    //random order to determine who would have to answer questions when
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random Rand=new Random(DateTime.Now.ToString().GetHashCode()); 
            //gets the hash value of a random element in the list
            var list = new List<string> { "Andrew", "Drew", "Kyle","Niteka",
                "Tai", "Yang Z", "Will", "Jay", "Yang Y", "Dwight", "Parker",
                "Christian", "Derek", "Peter", "David" };
            while(list.Count > 0) //while there is at least one element in the list keep going
            {
                int index = Rand.Next(0, list.Count);
                Console.WriteLine(list[index]);
                list.RemoveAt(index); //removes the randomly picked element from the list so its not picked again
            }
            Console.ReadLine();
        }
        
    }
}
