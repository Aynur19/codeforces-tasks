namespace CodeforcesTasks.CSharp;

public class Tasks
{
    public static void Task_71A()
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

    public static void Task_4A()
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
