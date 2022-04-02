using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Base_Code
{
    class Statistics
    {
        List<int> Attributes;

        

        public List<int> TerminalOut(List<int> Attributes) // method that displays the output at the end of the program, called by program
        {
            List<string> stat = new List<string>() { "Total characters: " + Attributes[5], "Lower case: " + Attributes[4], "Upper case: " + Attributes[3], "consonants: " + Attributes[2], "Vowels: " + Attributes[1], "Sentences: " + Attributes[0] };
            foreach(string stats in stat)
            {
                Console.WriteLine(stats);
            }
            return null;
        }
    }
}