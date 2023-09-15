var numberArray = new int[5];
numberArray[0] = 1;
numberArray[1] = 2;
numberArray[2] = 3;
numberArray[3] = 4;
numberArray[4] = 5;

foreach (int  i in numberArray)
{
    Console.WriteLine(i);   
}
Console.WriteLine("------------------"); 
for (int i = 0; i < numberArray.Length; i++)
{
    Console.WriteLine(numberArray[i]);
}
