/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


// Var 1
/*Console.WriteLine("Введите трехзначное целое число");
int number = int.Parse (Console.ReadLine()!);
int b = number.ToString().Length;
if (b != 3)
{
    Console.WriteLine("Это не трехзначное число, перезапустите программу");
}
else
{
   int secondDigit = number/10%10;
    Console.WriteLine(secondDigit);

}*/

// Var 2 - check incoming data for string 

Console.Clear();
Console.WriteLine("Введите трехзначное целое число");
var number = Console.ReadLine();

int numberInt;
    bool badIncome = int.TryParse(number, out numberInt);
    if ( badIncome)
    {
        Console.WriteLine("Молодец, это число!");
    }
    else
    {
        Console.WriteLine("This is not a valid number!");
        return;

    }
 int ourNumber = Convert.ToInt32(number);   


if (ourNumber<0)
{
    ourNumber = -ourNumber;

}
int b = ourNumber.ToString().Length;


if (b != 3)
{
    Console.WriteLine("Это не трехзначное число :( ");
}
else
{
    
    int secondDigit = ourNumber/10%10;
    Console.WriteLine($"Вторая цифра числа = {secondDigit}");

}
