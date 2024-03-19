string[] input = File.ReadAllLines("input.txt");
Dictionary<double, double> seeds = new Dictionary<double, double>();
double lowestValue = 0;
bool lowestValueAssigned = false;
lowestValueAssigned = false;
KeyValuePair<double, double>seed =  new();
double lowestSeed = 0;

string[] seedArray = input[0].Split(' ');

for (int i = 1; i < seedArray.Length; i = i + 2)
{
    seeds.Add(double.Parse(seedArray[i]), double.Parse(seedArray[i+1]));    
}

foreach(KeyValuePair<double, double> kvp in seeds)
{
    for(double i = kvp.Key; i < (kvp.Key + kvp.Value); i = i + 100000)
    {
        if(!lowestValueAssigned)
        {
            lowestValue = SeedToLocation(i);
            seed = kvp;
            lowestSeed = i;
            lowestValueAssigned = true;
        }
        else if(lowestValue > SeedToLocation(i))
        {
            lowestValue = SeedToLocation(i);
            seed = kvp;
            lowestSeed = i;
        }
    }
}
Console.WriteLine($"lowestValue: {lowestValue}, seed: {seed.Key} - {seed.Key + seed.Value}, specific seed: {lowestSeed}");
for(double i = 10000000; i >= 1; i = i/10)
{

double filterSize = i;
double RangeSearchFilter = Math.Floor(filterSize/10);
while (RangeSearchFilter < 1)
{
Console.WriteLine("RangeSearchFilter start");
    RangeSearchFilter++;
}
Console.WriteLine("RangeSearchFilter stop");

KeyValuePair<double, double> range = GetLimits(seed, filterSize); 

Console.WriteLine($"lowerlimit: {range.Key}, upperLimit: {range.Value}");

RangeSearch(range, RangeSearchFilter);
Console.WriteLine($"lowestValue: {lowestValue}, seed: {lowestSeed}");
}

Console.WriteLine($"lowestValue: {lowestValue}, seed: {lowestSeed}");

KeyValuePair<double, double> GetLimits (KeyValuePair<double, double> seed, double filterSize)
{
    
double lowerLimit = lowestSeed - filterSize;
double upperLimit = lowestSeed + filterSize;
while(lowerLimit < seed.Key)
{
Console.WriteLine("lowerLimit start");
    lowerLimit++;
}
Console.WriteLine("lowerLimit stop");
while(upperLimit > (seed.Key + seed.Value))
{
Console.WriteLine("upperLimit start");
    upperLimit --;
}
Console.WriteLine("upperLimit stop");
    KeyValuePair<double, double> range = new KeyValuePair<double, double>(lowerLimit, upperLimit); 
return range;
}
void RangeSearch(KeyValuePair<double, double> range, double filterSize)
{
    for (double ii = range.Key; ii <= range.Value; ii = ii + filterSize)
    {
        if(!lowestValueAssigned)
        {
            lowestSeed = ii;
            lowestValue = SeedToLocation(ii);
            lowestValueAssigned = true;
        }
        else if(lowestValue > SeedToLocation(ii))
        {
            lowestSeed = ii;
            lowestValue = SeedToLocation(ii);
        }
    }
}


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
                location = mapStart + (source - startSource );
                source = location;
                getMap = false;
            }
        }
        else if (line.Contains("map"))
        {
            getMap = true;
        }
    }
    return source;
}
