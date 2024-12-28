namespace FirstModuleFinalExam;

class Program
{
    static void Main(string[] args)
    {
        var word = Console.ReadLine();
        Console.WriteLine(StringStartsWith(word));
    }
    
    public static int CountOfEvenNumbers(List<int> numbers)
    {
        int count = 0;
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static bool AllElementsLengthBiggerFromFive(List<string> words)
    {
        var counter = 0;
        foreach (var word in words)
        {
            if (word.Length > 5)
            {
                counter++;
            }
        }

        if (counter == words.Count)
        {
            return true;
        }
        return false;
    }

    public static string SubstrFromAheadThree(string word)
    {
        var substredString = word.Substring(0, 3);
        return substredString;
    }

    public static bool StringStartsWith(string text)
    {
        var check = text.StartsWith("PDP");
        return check;
    }
}