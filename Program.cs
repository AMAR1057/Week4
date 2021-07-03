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
            string inp = Console.ReadLine();
            string[] inp_list;
            inp_list = inp.Split(' ');

            
            List<int> pairs = new List<int>();
            foreach (string i in inp_list)
            {
                pairs.Add(Convert.ToInt32(i));
            }
            int result = Matching_pairs(pairs);
            Console.WriteLine("Matching Pair:{0}", result);

        }

    }
}
