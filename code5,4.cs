List<int> nums = { 1, 5, 2, 4, 3 };
nums = nums.OrderByDescending(num => num).ToList();
Console.WriteLine(String.Join(", ", nums));