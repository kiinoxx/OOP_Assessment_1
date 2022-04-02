using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Base_Code
{
    public class Input
    {
        StreamReader file = new StreamReader(@"../../../Text.txt"); //determines the file location of the file being read
        public string text = "empty";
        

        public string userText(string Text)
        {
            Console.WriteLine("input text here: ");
            
            Text = Console.ReadLine(); // if entering text through keyboard, this is where the input is read and stored as the variable text
            text = Text;
            return text;
        }

        public string fileInput(string filename)
        {
            string filereader = file.ReadToEnd(); // if entering text from a file, this is where file text is read and stored as the variable text
            text = filereader;
            Console.WriteLine("file:\r\n{0}", filereader);

            return text;
        }
    }
}