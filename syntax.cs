//.Min() - minimuma
//.Max() - maxa
//.Sum() - sumata
//.Average() - sredno aritmetichno
//.Select() - pravi elementite v kolekciq
//.Where() - filtrira kolekcii po bool
//.OrderBy() - naj malko kum naj golqmo
//.OrderByDescending() - naj golqmo kum naj malko

var nums = new int[] { 10, 20, 30, 40 };
var nums2 = nums.Select(x => x / 2);
Console.WriteLine(String.Join(" ", nums2));