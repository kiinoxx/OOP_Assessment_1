namespace OOP_Assessment_1_Base_Code 
{
    class Program 
    {
        static void Main() 
        {
            List<int> parameters = new List<int>();

            Input input = new Input();

            Console.WriteLine("enter text via file?\r\nenter text via keyboard?\r\nF or KB");
            bool optionCheck = true;

            while(optionCheck == true)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine("option selected: "+userInput);

                switch (userInput)
                {
                    default:
                        Console.WriteLine("invalid option selected!");
                        optionCheck = true;
                        break;

                    case "F":
                        optionCheck = false;
                        input.userText(userInput);
                        break;

                    case "KB":
                        optionCheck = false;
                        input.fileInput(userInput);
                        break;
                }
            }

            Analysis analysis = new Analysis();
            analysis.textAnalysis(input.text);

            Statistics statistics = new Statistics(input.text, parameters);
            parameters = analysis.textAnalysis(input.text);

            statistics.TerminalOut(statistics);
        }
    }
}