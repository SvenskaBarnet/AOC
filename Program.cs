string[] data = File.ReadAllLines("data.csv");
int sum = 0;
int min = 0;
int max = 0;
foreach (string line in data)
{
    string[] elves = line.Split(',');
    string[] zonesA = elves[0].Split('-');
    string[] zonesB = elves[1].Split('-');
    min = int.Parse(zonesA[0]);
    max = int.Parse(zonesA[1]);
    if (min <= int.Parse(zonesB[0]) && max >= int.Parse(zonesB[1]))
    {
        sum++;
    }
    else if (min >= int.Parse(zonesB[0]) && max <= int.Parse(zonesB[1]))
    {
        sum++;
    }
}
Console.WriteLine(sum);