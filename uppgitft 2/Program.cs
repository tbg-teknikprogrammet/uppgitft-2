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
            string text;
            string totaltext = "";
            Console.Write("Output text here: ");
            text = Console.ReadLine();
            Console.WriteLine("when done output blank");
            int i = 0;
            while(text != "")
            {
                Console.Write("Output text here: ");
                text = Console.ReadLine();
                Console.WriteLine("when done output blank");
                totaltext = totaltext + "\n" + text;
            }
            Console.WriteLine(totaltext);
            Console.ReadKey();
        }
    }
}
