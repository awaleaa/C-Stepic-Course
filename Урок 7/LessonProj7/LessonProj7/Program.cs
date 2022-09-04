using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        PrintEven(GetMultiple(startValue, endValue));
    }

    public static List<int> GetMultiple(int startValue, int endValue)
    {
        int collection1Lenght = endValue - startValue + 1;
        int[] array = new int[collection1Lenght];
        for (int i = 0; i < collection1Lenght; i++)
        {
            array[i] = startValue;
            startValue++;
        }
        List<int> collection1 = new List<int>();
        for (int i = 1; i < collection1Lenght; i++)
        {
            collection1.Add(array[i]);
        }
        List<int> collection2 = new List<int>();
        for (int i = 0; i < collection1.Count; i++)
        {
            if ((collection1[i] % 7 ==0) && (collection1[i] != 0))
            {
                collection2.Add(collection1[i]);
            }
        }

        return collection2;
    }

    public static void PrintEven(List<int> collection2)
    {
        for (int i = 1; i < collection2.Count; i+=2)
        {
            Console.Write(collection2[i]+" ");
        } 
    }
}