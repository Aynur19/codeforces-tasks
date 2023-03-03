namespace CodeforcesTasks.CSharp;

public class Tasks
{
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
                for (int i = 0; i < n; i++)
                {
                    if (int.TryParse(strPoints[i], out int point) && point >= min && point > 0)
                    {
                        count++;
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
