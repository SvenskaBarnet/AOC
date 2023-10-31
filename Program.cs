string[] data = File.ReadAllLines("data.csv");
int sum = 0;
int min = 0;
int max = 0;

foreach (string line in data)
{
    string[] pair = line.Split(',');
    for (int i = 0; i < pair.Length; i++)
    {
        string elf = pair[i];
        string[] zone = elf.Split('-');
        if (i < 1)
        {
            min = int.Parse(zone[0]);
            max = int.Parse(zone[1]);
        }
        if (i > 0)
        {
            if (min <= int.Parse(zone[0]) && max >= int.Parse(zone[0]))
            {
                sum++;
            }
            else if (min <= int.Parse(zone[1]) && max >= int.Parse(zone[1]))
            {
                sum++;
            }
            else if (int.Parse(zone[0]) <= min && int.Parse(zone[1]) >= min)
            {
                sum++;
            }
            else if (int.Parse(zone[0]) <= max && int.Parse(zone[1]) >= max)
            {
                sum++;
            }
        }

    }
}

Console.WriteLine(sum);