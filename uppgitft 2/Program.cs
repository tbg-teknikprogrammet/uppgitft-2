using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgitft_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = "1st";
            int i = 0;
            while(text[i] != "")
            {
                text[i] = Console.ReadLine();
                i++;
            }
            foreach(int i in text )
        }
    }
}
