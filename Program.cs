string[] input = File.ReadAllLines("input-test.txt");

List<int> times = new List<int>();
List<int> distances = new List<int>();

foreach (string index in input[0].Split(' '))
{
    if(index != string.Empty && Char.IsDigit(index, 0))
    {
        times.Add(int.Parse(index));
    }
}

foreach (string index in input[1].Split(' '))
{
    if(index != string.Empty && Char.IsDigit(index, 0))
    {
        distances.Add(int.Parse(index));
    }
}
