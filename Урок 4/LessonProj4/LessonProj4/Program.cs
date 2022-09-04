using System;

public class MainClass
{
    public static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        for (int i = height-1; i >= 0; i--)
        {
            for (int j = height - i; j < height; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < height - i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j < height - i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}