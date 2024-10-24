using System;

class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(4);
        Console.WriteLine();
        Write1ThroughN_For(6);
        Console.WriteLine();
        WriteNThrough1_While(8);
        Console.WriteLine();
        WriteNThrough1_For(9);
        Console.WriteLine();
        WriteEvensThrough100();
        Console.WriteLine();
        FindSum(5);
        Console.WriteLine();
        FindSumOfEvenNumbers(10);
        Console.WriteLine();
        FindSumOfOddNumbers(10);
        Console.WriteLine();
        OutputRightTriangle(-4);
    }

    public static void Write1ThroughN_While(int n)
    {
        int counter = 1;
        if (n < 1)
        {
            Console.WriteLine(n + " is not in range");
        }
        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        int counter = 1;
        if (n < 1)
        {
            Console.WriteLine(n + " is not in range");
        }
        for (counter = 1; counter <= n; counter++)
        {
            Console.WriteLine(counter);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        int counter = 1;
        if (n < 1)
        {
            Console.WriteLine(n + " is not in range");
        }
        while (counter <= n)
        {
            Console.WriteLine(n);
            n--;
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        int counter = 1;
        if (n < 1)
        {
            Console.WriteLine(n + " is not in range");
        }
        for (counter = 1; counter <= n; n--)
        {
            Console.WriteLine(n);
        }
    }

    public static void WriteEvensThrough100()
    {
        for (int even = 1; even <= 100; even++)
        {
            if (even % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(even);
        }
    }

    public static void FindSum(int n)
    {
        int counter = 1;
        int sum = 0;
        for (counter = 1; counter <= n; counter++)
        {
            if (counter <= n)
            {
                sum = counter + sum;
                continue;
            }
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int counter = 1;
        int sum = 0;
        for (counter = 1; counter <= n; counter++)
        {
            if (counter <= n)
            {
                if (counter % 2 == 1)
                {
                    continue;
                }
                sum = counter + sum;
                continue;
            }
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int counter = 1;
        int sum = 0;
        for (counter = 1; counter <= n; counter++)
        {
            if (counter <= n)
            {
                if (counter % 2 == 0)
                {
                    continue;
                }
                sum = counter + sum;
                continue;
            }
        }
        Console.WriteLine(sum);
    }

    public static void OutputRightTriangle(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("0 is not in range");
            return;
        }
        if (n > 0)
        {
            for (int line = 1; line <= n; line++)
            {
                for (int star = 0; star < line; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        if (n < 0)
        {
            for (int line = -1; line >= n; n++)
            {
                for (int star = 0; star > n; star--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}