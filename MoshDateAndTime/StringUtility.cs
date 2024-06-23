using System.Collections.Generic;

namespace MoshDateAndTime
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLenght = 20)
        {

            if (text.Length < maxLenght)
                return text;
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWord = new List<string>();

                foreach (var word in words)
                {
                    totalCharacters += word.Length + 1;
                    summaryWord.Add(word);
                    if (totalCharacters > maxLenght)
                        break;

                }


                return string.Join(" ", summaryWord) + "..."; ;
            }
        }
    }
}