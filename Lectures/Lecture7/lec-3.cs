var numbers = new List<int>() { 1,2,3,7,8,9,10,12,14,15,16};
var evenNumberSquared = numbers.Where(x => x % 2 == 0)
    .Select(x => Math.Pow(x, 2)); ;

var num = numbers.FirstOrDefault();
Console.WriteLine(num);

Console.WriteLine("--------");
foreach (var number in evenNumberSquared)
    Console.WriteLine(number);
