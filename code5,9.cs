int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(n => n).ToArray();
int count = 0;
for (int i = 0; i < numbers.Length && count < 5; i++)
{
    if (numbers[i] % 2 != 0)
    {
        Console.Write($"{numbers[i]} ");
        count++;
    }
}