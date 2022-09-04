using System;

public class LessonProj1
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);

      

        if ( (a <= b) && (a <=c) )
        {
            Console.WriteLine($"{a}");
        }
        else if ((b <= a) && (b <= c))
        {
            Console.WriteLine($"{b}");

        }
        else
        {
            Console.WriteLine($"{c}");
        }
        return;


        
    }
}