namespace CodeforcesTasks.CSharp;

public class Tasks
{
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
