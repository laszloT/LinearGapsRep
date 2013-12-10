using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinearGaps
{
    class Program
    {
        public static List<int> IntsNotIn(List<int> pList)
        {
            pList.Sort();
            int low = pList[0];
            int high = pList[pList.Count - 1];
            List<int> rLis = new List<int>();
            int ind = 0;
            while ((low < high))
            {
                if (pList[ind] != low)
                    rLis.Add(low);
                else
                    ind++;
                low++;

            }
            return rLis;
        }

        static void Main(string[] args)
        {
            Random  myRan = new Random();
            List<int> myList = new List<int>();

            //either test it with this for loop (in which case you may have to run it more than once)
            //or use a series of adds like the ones below below

            for (int i = 0; i < 1000; i++)
                if (i != myRan.Next(1000))  
                    myList.Add(i);
            /*myList.Add(46);
            myList.Add(47);
            myList.Add(44);
            myList.Add(49);*/
            List<int> myList2 = IntsNotIn(myList);
            for (int i = 0; i < myList2.Count; i++)
                System.Console.WriteLine(myList2[i]);
            System.Console.Read();
        }
    }
}
