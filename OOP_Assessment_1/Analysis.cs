using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Base_Code
{
    public class Analysis
    {
        public List<int> textAnalysis(string input)
        {
           
                List<int> values = new List<int>();
                for (int i = 0; i < 6; i++)
                {
                    values.Add(0); // initially sets values in list to zero
                }

            // lists used to store characters that are being seatchedd for
            char[] lowCaseVowel = { 'a', 'e', 'i', 'o', 'u' };
            char[] lowCaseCon = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'w', 'y' };
            char[] upCaseVowel = { 'A', 'E', 'I', 'O', 'U' };
            char[] upCaseCon = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Z', 'W', 'Y' };
            char[] sentence = { '.', '!', '?' };

            // counters that correspond to the number of characters being searched for and found in the text
            int sentenceCount = 0;
            int upVowelCount = 0;
            int lowVowelCount = 0;
            int lowConCount = 0;
            int upConCount = 0;
            int lowLetterCount = 0;
            int upLetterCount = 0;

            foreach (char i in input) // iterates through the text
            {
                if (sentence.Contains(i)) // if and else if statements used to search for specific characters  in text
                {
                    sentenceCount++; // if the character has been found in the text, the corresponding counter is increased by 1

                }
                else if (lowCaseVowel.Contains(i))
                {
                    lowVowelCount++;
                    lowLetterCount++;

                }
                else if (upCaseVowel.Contains(i))
                {
                    upVowelCount++;
                    upLetterCount++;

                }
                else if (lowCaseCon.Contains(i))
                {
                    lowConCount++;
                    lowLetterCount++;

                }
                else if (upCaseCon.Contains(i))
                {
                    upConCount++;
                    upLetterCount++;

                }
            }
            int totalChar = lowLetterCount + upLetterCount + sentenceCount; // finds total of all characters in text
            int vowelCount = upVowelCount + lowVowelCount; // finds total of vowels found in text
            int conCount = upConCount + lowConCount; // finds total of consonants
            values[0] = sentenceCount; // sets the values variable to the corresponding counter
            values[1] = vowelCount;
            values[2] = conCount;
            values[3] = upLetterCount;
            values[4] = lowLetterCount;
            values[5] = totalChar;
            return values; // returns the values above
            
        }
    }
}