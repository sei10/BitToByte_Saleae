using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            List<int> bin = new List<int>();
            bin.Add(1);
            bin.Add(0);
            bin.Add(1);
            bin.Add(0);

            List<Data> data = new List<Data>();
            Data OneData = new Data();
            OneData.time =0.1;
            OneData.setBin(bin);
            data.Add(OneData);

            foreach(var n in data)
            {
                bin=n.getBin();
                Console.WriteLine(n.time.ToString());
                foreach(var m in bin)
                {
                Console.WriteLine(m.ToString());

                }
            }
        }
    }
    class Data
    {
        public double time{get;set;}
        private List<int> bin = new List<int>();
        public List<int> getBin() 
        {
            return bin;
        }
        public void setBin(List<int> list)
        {
            this.bin = list;
        }
 //       @override
 //       public String ToString()
 //       {
 //           return("a");
 //       }
    }

    class Bit
    {
//        public int SearchStart()
    }
}