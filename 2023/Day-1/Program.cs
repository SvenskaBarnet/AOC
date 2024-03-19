string[] data = File.ReadAllLines("data.txt");
int sum = 0;

foreach (string line in data)
{
    Console.WriteLine(line);
    bool digitFound = false;
	string number = "";
	string spelledNumber = "";
	for (int i = 0; i < line.Length; i++)
	{
		if (char.IsDigit(line[i]) && !digitFound)
		{
			number = $"{line[i]}";
			digitFound = true;
		}
		else if (!char.IsDigit(line[i]) && !digitFound)
		{
			spelledNumber = $"{spelledNumber}{line[i]}";
			if (spelledNumber.Contains("one"))
			{
				number = "1";
				digitFound = true;
			}
			if (spelledNumber.Contains("two"))
			{
				number = "2";
				digitFound = true;
			}
			if (spelledNumber.Contains("three"))
			{
				number = "3";
				digitFound = true;
			}
			if (spelledNumber.Contains("four"))
			{
				number = "4";
				digitFound = true;
			}
			if (spelledNumber.Contains("five"))
			{
				number = "5";
				digitFound = true;
			}
			if (spelledNumber.Contains("six"))
			{
				number = "6";
				digitFound = true;
			}
			if (spelledNumber.Contains("seven"))
			{
				number = "7";
				digitFound = true;
			}
			if (spelledNumber.Contains("eight"))
			{
				number = "8";
				digitFound = true;
			}
			if (spelledNumber.Contains("nine"))
			{
				number = "9";
				digitFound = true;
			}
		}
    }
    digitFound = false;
	spelledNumber = "";
	for (int i = line.Length - 1; i >= 0; i--)
	{
		if (char.IsDigit(line[i]) && !digitFound)
		{
			number = $"{number}{line[i]}";
			digitFound = true;
		}
		else if (!char.IsDigit(line[i]) && !digitFound)
		{
			spelledNumber = $"{line[i]}{spelledNumber}";
			if (spelledNumber.Contains("one"))
			{
				number = $"{number}1";
				digitFound = true;
			}
			if (spelledNumber.Contains("two"))
			{
				number = $"{number}2";
				digitFound = true;
			}
			if (spelledNumber.Contains("three"))
			{
				number = $"{number}3";
				digitFound = true;
			}
			if (spelledNumber.Contains("four"))
			{
				number = $"{number}4";
				digitFound = true;
			}
			if (spelledNumber.Contains("five"))
			{
				number = $"{number}5";
				digitFound = true;
			}
			if (spelledNumber.Contains("six"))
			{
				number = $"{number}6";
				digitFound = true;
			}
			if (spelledNumber.Contains("seven"))
			{
				number = $"{number}7";
				digitFound = true;
			}
			if (spelledNumber.Contains("eight"))
			{
				number = $"{number}8";
				digitFound = true;
			}
			if (spelledNumber.Contains("nine"))
			{
				number = $"{number}9";
				digitFound = true;
			}
		}
    }
    Console.WriteLine(number);
    sum += int.Parse(number);
}

Console.WriteLine(sum);
