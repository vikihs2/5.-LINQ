string name = Console.ReadLine();
if (IsValidName(name))
{
    PrintGreeting(name);
    PrintAsciiValuesIncreased(name);
}
else
{
   PrintInvalidName();
}
static bool IsValidName(string name)
{
    if (string.IsNullOrEmpty(name) || name.Length < 3 || !char.IsUpper(name[0]) || name.Any(char.IsDigit))
    {
        return false;
    }
    return true;
}
static void PrintGreeting(string name) => Console.WriteLine($"Hello, {name}!");
static void PrintAsciiValuesIncreased(string name)
{
    foreach (char c in name)
    {
        int asciiValue = c + 10;
        Console.WriteLine(asciiValue);
    }
}
static void PrintInvalidName() => Console.WriteLine("Invalid name!");