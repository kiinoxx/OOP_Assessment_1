namespace OOP_Assessment_1_Base_Code
{
    public class Analysis
    {
        int len;

        public List<int> textAnalysis(string input)
        {
            List<int> values = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                values.Add(0); // initially sets values in list to zero
            }

            len = input.Length;

            for (int i = 0; i < len; i++)
            {
                if (input[i] == '.')
                {
                    values[0]++; //increments the sentence counter
                }

                if (input[i] == 'a' || input[i] == 'i' || input[i] == 'u' || input[i] == 'o' || input[i] == 'e' || input[i] == 'A' || input[i] == 'I' || input[i] == 'U' || input[i] == 'E' || input[i] == 'O')
                {
                    values[1]++;
                }
                else if (input[i] >= 'a' && input[i] <= 'z' || input[i] >= 'A' && input[i] <= 'Z')
                {
                    values[2]++;
                }

                // upper & lower case counted
                // maximum character counted
                if (char.IsUpper(input[i]))
                {
                    values[3]++;
                    values[5]++;
                }
                else if (char.IsLower(input[i]))
                {
                    values[4]++;
                    values[5]++;
                }
            }

            return values;
        }
    }
}