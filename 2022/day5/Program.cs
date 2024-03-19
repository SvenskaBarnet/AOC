using supply_stacks.bin;
using System.Collections;
using System.Diagnostics;

DateTime start = DateTime.Now;

Stack<char> one = new Stack<char>();
Stack<char> two = new Stack<char>();
Stack<char> three = new Stack<char>();
Stack<char> four = new Stack<char>();
Stack<char> five = new Stack<char>();
Stack<char> six = new Stack<char>();
Stack<char> seven = new Stack<char>();
Stack<char> eight = new Stack<char>();
Stack<char> nine = new Stack<char>();

string[] stacks = File.ReadAllLines("stacks.txt");
foreach (string line in stacks)
{
    Console.WriteLine(line);
}
for (int i = (stacks.Length - 2); i >= 0; i--)
{
    string line = stacks[i];
    for (int j = 0; j < line.Length; j++)
    {
        switch (j)
        {
            case 1:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    one.Push(line[j]);
                }
                break;
            case 5:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    two.Push(line[j]);
                }
                break;
            case 9:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    three.Push(line[j]);
                }
                break;
            case 13:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    four.Push(line[j]);
                }
                break;
            case 17:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    five.Push(line[j]);
                }
                break;
            case 21:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    six.Push(line[j]);
                }
                break;
            case 25:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    seven.Push(line[j]);
                }
                break;
            case 29:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    eight.Push(line[j]);
                }
                break;
            case 33:
                if ((int)line[j] is > 64 and < 91 || (int)line[j] is > 96 and < 123)
                {
                    nine.Push(line[j]);
                }
                break;
        }
    }
}

string[] instructions = File.ReadAllLines("instructions.txt");
Stack<char> popped = new Stack<char>();

foreach (string line in instructions)
{
    string[] instruction = line.Split(' ');
    for (int i = 0; i < int.Parse(instruction[1]); i++)
    {
        switch (instruction[3])
        {
            case "1":
                popped.Push(one.Pop());
                break;
            case "2":
                popped.Push(two.Pop());
                break;
            case "3":
                popped.Push(three.Pop());
                break;
            case "4":
                popped.Push(four.Pop());
                break;
            case "5":
                popped.Push(five.Pop());
                break;
            case "6":
                popped.Push(six.Pop());
                break;
            case "7":
                popped.Push(seven.Pop());
                break;
            case "8":
                popped.Push(eight.Pop());
                break;
            case "9":
                popped.Push(nine.Pop());
                break;
        }
    }
    for (int i = 0; i < int.Parse(instruction[1]); i++)
    {
        switch (instruction[5])
        {
            case "1":
                one.Push(popped.Pop());
                break;
            case "2":
                two.Push(popped.Pop());
                break;
            case "3":
                three.Push(popped.Pop());
                break;
            case "4":
                four.Push(popped.Pop());
                break;
            case "5":
                five.Push(popped.Pop());
                break;
            case "6":
                six.Push(popped.Pop());
                break;
            case "7":
                seven.Push(popped.Pop());
                break;
            case "8":
                eight.Push(popped.Pop());
                break;
            case "9":
                nine.Push(popped.Pop());
                break;
        }

    }
}


Console.Write("\n1:");
foreach (char line in one)
{
    Console.Write(line + ", ");
}
Console.Write("\n2:");
foreach (char line in two)
{
    Console.Write(line + ", ");
}
Console.Write("\n3:");
foreach (char line in three)
{
    Console.Write(line + ", ");
}
Console.Write("\n4:");
foreach (char line in four)
{
    Console.Write(line + ", ");
}
Console.Write("\n5:");
foreach (char line in five)
{
    Console.Write(line + ", ");
}
Console.Write("\n6:");
foreach (char line in six)
{
    Console.Write(line + ", ");
}
Console.Write("\n7:");
foreach (char line in seven)
{
    Console.Write(line + ", ");
}
Console.Write("\n8:");
foreach (char line in eight)
{
    Console.Write(line + ", ");
}
Console.Write("\n9:");
foreach (char line in nine)
{
    Console.Write(line + ", ");
}

DateTime end = DateTime.Now;

TimeSpan ts = (end - start);

Console.WriteLine("\n\nThe execution time is {0} ms", ts.TotalMilliseconds);
