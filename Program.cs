string[] input = File.ReadAllLines("input.txt");
Dictionary<double, double> seeds = new Dictionary<double, double>();
double lowestValue = 0;
KeyValuePair<double, double>seed =  new();

string[] seedArray = input[0].Split(' ');

for (int i = 1; i < seedArray.Length; i = i + 2)
{
    seeds.Add(double.Parse(seedArray[i]), double.Parse(seedArray[i+1]));    
}

foreach(KeyValuePair<double, double> kvp in seeds)
{
    for(double i = kvp.Key; i <= (kvp.Key + kvp.Value); i++)
    {
        if(lowestValue == 0)
        {
            lowestValue = SeedToLocation(i);
            seed = kvp;
        }
        if(lowestValue > i)
        {
            lowestValue = SeedToLocation(i);
            seed = kvp;
        }
    }
}
Console.Write($"lowestValue: {lowestValue}, seed: {seed.Key} - {seed.Key + seed.Value}");

double SeedToLocation(double seedValue)
{
    double source = seedValue;
    bool getMap = false;
    foreach (string line in input)
    {
        if (line == string.Empty)
        {
            getMap = false;
        }
        else if(getMap)
        {
            string[] map = line.Split(" ");
            double location = 0;
            double mapStart = double.Parse(map[0]);
            double startSource = double.Parse(map[1]);
            double mapLength = double.Parse(map[2]);

            if(source >= startSource && source <= startSource + mapLength - 1)
            {
                location = mapStart + source - startSource;
                source = location;
                Console.WriteLine(source);
            }
        }
        else if (line.Contains("map"))
        {
            Console.WriteLine(line);
    Console.WriteLine($"new source: {source} old source: {seedValue}");
            getMap = true;
        }
    }
    return source;
}
