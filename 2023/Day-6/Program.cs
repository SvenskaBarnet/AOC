string[] input = File.ReadAllLines("input.txt");

string time = string.Empty;
string distance = string.Empty;

foreach (string index in input[0].Split(' '))
{
    if(index != string.Empty && Char.IsDigit(index, 0))
    {
        time += index;
    }
}

foreach (string index in input[1].Split(' '))
{
    if(index != string.Empty && Char.IsDigit(index, 0))
    {
        distance += index;
    }
}

double totalTime = double.Parse(time);
double minDistance = double.Parse(distance);

double validCount = CountValidOptions(totalTime, minDistance);
Console.WriteLine(validCount);

double CountValidOptions (double time, double minDistance)
{
    double delta = (Math.Pow(time, 2)) - (4*minDistance);
    if(delta < 0)
    {
        return 0;
    }
    double sqrtDelta = Math.Sqrt(delta);
    double hold1 = (time + sqrtDelta) / 2;
    double hold2 = (time - sqrtDelta) / 2;
    double area = ((Math.Pow(hold1, 2) - Math.Pow(hold2, 2))/2);
    double integerReturn = Math.Floor(2* area / time);
    return integerReturn;
}
