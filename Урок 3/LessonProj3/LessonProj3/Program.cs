using System;

public class LessonProj3
{
    public static void Main()
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int operation = Convert.ToInt32(splitString[0]);
        double a = Convert.ToDouble(splitString[1]);
        double b = Convert.ToDouble(splitString[2]);
        double result = 0;
        
        if (operation == 1)
        {
            result = a + b;
            Console.WriteLine($"Результат операции {result}");
        }
        else if (operation == 2)
        {
            result = a - b;
            Console.WriteLine($"Результат операции {result}");
        }
        else if (operation == 3){
            result = a * b;
            Console.WriteLine($"Результат операции {result}");
        }
       
        return;


        

    }
}