string input = Console.ReadLine();
string[] words = input.Split(' ');
string[] filteredWords = words.Where(word => word.Contains("est")).Select(word => word.ToUpper()).ToArray();
string firstWithB = filteredWords.FirstOrDefault(word => word.Contains("B"));
string lastWithB = filteredWords.LastOrDefault(word => word.Contains("B"));
Console.WriteLine("First word containing 'B': " + (firstWithB ?? "Not found"));
Console.WriteLine("Last word containing 'B': " + (lastWithB ?? "Not found"));