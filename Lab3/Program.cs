Console.WriteLine("player A enter a number between 1-8");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number > 8)
{
    Console.WriteLine("wrong number enter a number between 1-8.");
    return;
}
Console.WriteLine("player A enter a number between 8-16");
int number2 = int.Parse(Console.ReadLine());
if (number2 < 8 || number2 > 16)
{
    Console.WriteLine("wrong number enter a number between 8-16.");
    return;
}   
Console.WriteLine("player b enter a number between 1-8");
int number3 = int.Parse(Console.ReadLine());
if (number3 < 1 || number3 > 8)
{
    Console.WriteLine("wrong number enter a number between 1-8.");
    return;
}
Console.WriteLine("player b enter a number between 8-16");
int number4 = int.Parse(Console.ReadLine());
if (number4 < 8 || number4 > 16)
{
    Console.WriteLine("wrong number enter a number between 8-16.");
    return;
} 
int totalA = number + number2;
int totalB = number3 + number4;
while (totalA != totalB)
{
    if (totalA > totalB)
    {
        Console.WriteLine("player A wins");
        break;
    }
    else
    {
        Console.WriteLine("player B wins");
        break;
    }
    
}