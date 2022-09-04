using System;

public class MainClass
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        int answer = 0;
       for (int i = startValue; i <= endValue; i++)
        {
            if (IsPrime(i)) answer += i;
        }
       Console.WriteLine(answer);
    }
       public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        
    }
  
}