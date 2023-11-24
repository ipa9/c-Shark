var numbers = new List<int>() { 1,2,3,7,8,9,10,12,14,15,16};
var evenNumbers = numbers.Where(x => x % 2 == 0);

foreach (var evenNumber in evenNumbers)
    Console.WriteLine(evenNumber);
