namespace rucksack;

public class PartTwo
{
    public static void Solution()
    {
        string[] data = File.ReadAllLines("data.txt");
        int count = 0;
        int sum = 0;
        string? first = null;
        string? second = null;
        int item = 0;
        foreach (string line in data)
        {
            switch (count)
            {
                case 0:
                    first = line;
                    count++;
                    break;
                case 1:
                    second = line;
                    count++;
                    break;
                case 2:
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (first.Contains(line[i]) && second.Contains(line[i]))
                        {
                            if ((int)line[i] is > 96 and < 123)
                            {
                                item = (int)line[i] - 96;
                            }
                            else if ((int)line[i] is > 64 and < 91)
                            {
                                item = (int)line[i] - 38;
                            }
                        }
                    }
                    sum += item;
                    count = 0;
                    break;
            }
        }
        Console.WriteLine(sum);

    }
}