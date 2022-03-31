using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Base_Code
{
    public class Input
    {
        StreamReader file = new StreamReader(@"../../../Text.txt");
        public string text = "";
        

        public string userText(string Text)
        {
            Console.WriteLine("input text here: ");
            text = Text;
            return text;
        }

        public string fileInput(string filename)
        {
            string filereader = file.ReadToEnd();
            text = filereader;
            Console.WriteLine("file:\r\n{0}", filereader);

            return text;
        }
    }
}