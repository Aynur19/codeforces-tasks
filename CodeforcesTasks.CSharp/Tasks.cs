namespace CodeforcesTasks.CSharp;

public class Tasks
{
    public static void Task_282_A()
    {
        var operIncrement = "++";
        var x = 0;

        var strN = Console.ReadLine();

        if (strN is not null && int.TryParse(strN, out int n))
        {
            for (int i = 0; i < n; i++)
            {
                if (Console.ReadLine().Contains(operIncrement))
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
        }

        Console.WriteLine(x);
    }

    public static void Task_50_A()
    {
        var minDim = 1;
        var maxDim = 16;
        var dominoSize = 2;
        var dims = Console.ReadLine()?.Split(' ');

        if (dims is not null && dims.Length >= 2
            && int.TryParse(dims[0], out int m) && m >= minDim && m <= maxDim
            && int.TryParse(dims[1], out int n) && n >= m && m <= maxDim)
        {
            int count = m * n / dominoSize;
            Console.WriteLine(count);
        }
    }

    public static void Task_158_A()
    {
        var strNumbers = Console.ReadLine()?.Split(new char[] { ' ' });

        if (strNumbers is not null
            && int.TryParse(strNumbers[1], out int k) && k > 0
            && int.TryParse(strNumbers[0], out int n) && n >= k)
        {
            int count = 0;
            var strPoints = Console.ReadLine()?.Split(new char[] { ' ' });

            if (strPoints is not null && strPoints.Length == n && int.TryParse(strPoints[k - 1], out int min))
            {
                if (min > 0)
                {
                    count += k;

                    for (int i = k; i < n; i++)
                    {
                        if (int.TryParse(strPoints[i], out int point) && point >= min && point > 0)
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    for (int i = k - 1; i >= 0; i--)
                    {
                        if (int.TryParse(strPoints[i], out int point) && point >= min && point > 0)
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }

    public static void Task_231_A()
    {
        var strN = Console.ReadLine();
        if (!int.TryParse(strN, out var n) || n <= 0)
        {
            return;
        }

        int numberCount = 3;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            var numbersStr = Console.ReadLine()?.Split(new char[] { ' ' });
            int confidentCount = 0;
            if (numbersStr is not null && numbersStr.Length >= numberCount)
            {
                for (int k = 0; k < numberCount; k++)
                {
                    if (int.TryParse(numbersStr[k], out var number) && number == 1)
                    {
                        confidentCount++;
                    }
                }

                if (confidentCount >= 2)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    public static void Task_71_A()
    {
        var strN = Console.ReadLine();
        if (int.TryParse(strN, out var n))
        {
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (words[i].Length > 10)
                {
                    Console.WriteLine($"{words[i][0]}{words[i].Length - 2}{words[i][^1]}");
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }

    public static void Task_4_A()
    {
        var strWeight = Console.ReadLine();
        bool isNumber = int.TryParse(strWeight, out var weight);

        if (isNumber && weight % 2 == 0 && weight > 2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
