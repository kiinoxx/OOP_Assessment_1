namespace OOP_Assessment_1_Base_Code
{
    class Statistics
    {
        List<int> Attributes;

        public Statistics(string text, List<int> attributes)
        {
            Attributes = attributes;
            Attributes.ToString();
        }

        public void TerminalOut()
        {
            List<string> stat = new List<string>() { "Maximum characters: " + Attributes[5], "Lower case: " + Attributes[4], "Upper case: " + Attributes[3], "consonants: " + Attributes[2], "Vowels: " + Attributes[1], "Sentences: " + Attributes[0] };
            foreach(string stats in stat)
            {
                Console.WriteLine(stats);
            }
        }
    }
}