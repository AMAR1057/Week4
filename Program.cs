using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {


        static int Matching_pairs(List<int> inp_list)//funtion to calculate matching pairs
        {
            int ans = 0; //to store number of matching pairs

            //using Linq
            Dictionary<int, int> pair = inp_list.GroupBy(x => x)
                    .Where(c => c.Count() > 1)
                    .ToDictionary(x => x.Key, x => x.Count()); //using linq and counting number of same color socks & mapping with respective color interger
            foreach (int values in pair.Values)  //traversing all values pair dictionary to calculate the matching pair

            {

                ans += values /2;
            }

            return ans;
        }
        static void Main(string[] args)
        {
            string inp = Console.ReadLine(); //taking sentence input from user
            string[] inp_list;
            inp_list = inp.Split(' ');   //converting space separated user input as an array

            
            List<int> pairs = new List<int>();  //list of integer type to hold all colors of the socks
            foreach (string i in inp_list)
            {
                pairs.Add(Convert.ToInt32(i)); //adding all colors of the socks in the pile
            }
            int result = Matching_pairs(pairs); //calling function to calculate total number of matching 
            Console.WriteLine("Matching Pair:{0}", result); //displaying result of matching pairs

        }

    }
}
