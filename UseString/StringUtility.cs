namespace UseString;

public class StringUtility
{
    public static string SummerizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;

        var words = text.Split(' ');
        var totalCharacters = 0;
        var summaryWords = new List<string>();

        foreach (var word in words)
        {
            summaryWords.Add(word);
            totalCharacters += word.Length + 1;
            if (totalCharacters > maxLength)
                break;
        }
        return String.Join(" ", summaryWords) + " ...";
    }
    public static bool IsConsecutiveList(List<int> numbers)
    {
        numbers.Sort();
        var isConsecutive = true;
        for (var i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
            {
                isConsecutive = false;
                break;
            }
        }

        return isConsecutive;
    }
}