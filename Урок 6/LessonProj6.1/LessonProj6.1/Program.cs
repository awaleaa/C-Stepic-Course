using System;

public class MainClass
{
    public static void Main()
    {
        string courseWork = Console.ReadLine();
        if (IsTextIncludesChar(courseWork))
        {
            Console.WriteLine("В тексте присутствуют латинские символы!");
        }
        else
        {
            Console.WriteLine("Латинские символы отсутствуют");
        }
    }
    public static bool IsTextIncludesChar(string text)
    {
        for (int i = 0; i < text.Length; i++)

            if (text[i] == 'e')
                return true;
        return false;

    }
}