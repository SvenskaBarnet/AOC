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
    for(double i = kvp.Key; i <= kvp.Key + kvp.Value; i = i + Math.Floor(Math.Sqrt(kvp.Key)))
    {
        if(lowestValue == 0)
        {
            lowestValue = i;
            seed = kvp;
        }
        if(lowestValue > i)
        {
            lowestValue = i;
            seed = kvp;
        }
    }
}

double SeedToLocation(double seed)
{
    double internalSeed = seed;
    foreach (string line in input)
    {
        if (line[1].ToString() == "map:")
        {

        }
    }
}
