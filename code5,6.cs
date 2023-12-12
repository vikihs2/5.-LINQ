string input = Console.ReadLine();
string[] numbersAsString = input.Split(' ');
int[] numbers = Array.ConvertAll(numbersAsString, int.Parse);
foreach (int number in numbers)
{
    bool isOdd = IsOdd(number);
    Console.WriteLine($"{number} is odd - {isOdd}");
}
static bool IsOdd(int number) => number % 2 != 0;