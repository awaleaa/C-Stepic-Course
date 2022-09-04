using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int temp;
        int[] numbers = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
            numbers[i] = int.Parse(array[i]);
        for (int i = 0; i <= numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]+" ");
        }
    }
}