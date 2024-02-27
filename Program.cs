string[] input = File.ReadAllLines("input-test.txt");

string [] times = input[0].Split(' ');
string [] distances = input[1].Split(' ');
foreach (string index in input)


foreach (string line in times){
    Console.Write(line + ", ");
}
Console.WriteLine();
foreach (string line in distances){
    Console.Write(line + ", ");
}
