using System;

public class LessonProj2
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);
        int d = Convert.ToInt32(splitString[3]);

        int minValue = 0;
        int maxValue = 0;

        if ((a <= b) && (a <= c) && (a <= d))
        {
            Console.WriteLine($"Наименьшее число - {a}");
        }
        else if ((b <= a) && (b <= c) && (b <= d) )
        {
            Console.WriteLine($"Наименьшее число - {b}");

        }
        else if ((c <= a) && (c <= b) && (c <= d))
        {
            Console.WriteLine($"Наименьшее число - {c}");
        }
        else
        {
            Console.WriteLine($"Наименьшее число - {d}");
        }
       
        if ((a >= b) && (a >= c) && (a >= d))
        {
            Console.WriteLine($"Наибольшее число - {a}");
        }
        else if ((b >= a) && (b >= c) && (b >= d))
        {
            Console.WriteLine($"Наибольшее число - {b}");

        }
        else if ((c >= a) && (c >= b) && (c >= d))
        {
            Console.WriteLine($"Наибольшее число - {c}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число - {d}");
        }
        return;


        Console.WriteLine($"Наибольшее число - {maxValue}");

    }
}