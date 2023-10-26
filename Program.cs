List<int> sums = new List<int>();
string[] data = File.ReadAllLines("data.txt");
int sum = 0;
foreach (string line in data)
{
    if (line.Equals(string.Empty))
    {
        sums.Add(sum);
        sum = 0;
    }
    else
    {
        if (int.TryParse(line, out int value))
        {
            sum += value;
        }
    }
}

for (int i = 0; i < sums.Count; i++)
{
    int maxValue = sums[i];
    for (int j = i + 1; j < sums.Count - 1; j++)
    {
        if (sums[i] < sums[j])
        {
            maxValue = sums[j];
            int tempInt = sums[i];
            sums[i] = maxValue;
            sums[j] = tempInt;
        }
    }
}

int topThreeSum = sums[0] + sums[1] + sums[2];

Console.WriteLine(topThreeSum);

