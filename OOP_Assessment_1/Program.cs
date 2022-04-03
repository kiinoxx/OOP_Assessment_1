using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Base_Code 
{
    class Program 
    {
        static void Main() 
        {
            List<int> parameters = new List<int>();

            Input input = new Input();
            Analysis analysis = new Analysis();

            Console.WriteLine("enter text via file?\r\nenter text via keyboard?\r\nF or KB");
            bool optionCheck = true;

            while(optionCheck == true) // creates a loop in which only a valid choice will let the user progress any further
            {
                string read;
                string userInput = Console.ReadLine();
                Console.WriteLine("option selected: "+userInput);

                switch (userInput)
                {
                    default:
                        Console.WriteLine("invalid option selected!");
                        Console.WriteLine("try again");
                        optionCheck = true;
                        break;

                    case "KB" or "kb": // choice to input text into the console directly instead of using a file
                        optionCheck = false;
                        read = input.userText(userInput);
                        parameters = analysis.textAnalysis(read);
                        break;

                    case "F" or "f": // text input through a file
                        optionCheck = false;
                        read = input.fileInput(userInput);
                        parameters = analysis.textAnalysis(read);
                        break;
                }
            }

            

            Statistics statistics = new Statistics();
            

            statistics.TerminalOut(parameters); // method from statistics called to output analysed text
        }
    }
}