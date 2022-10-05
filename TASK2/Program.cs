//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*645 -> 5

78 -> третьей цифры нет

32679 -> 6

Проверяет неправильный ввод - символы, 0, <10 , null, работает с отрицательными числами*/


Console.WriteLine("Введите целое число");
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
    if (b==0||b ==1|| b==2)
    {
        Console.WriteLine("Нет третьей цифры :( ");
        return;
    }
    
    int thirdNumber =0;
    for (int i= 0; i<b-3; i++)
    {
    ourNumber = ourNumber/10;

    }
     thirdNumber = ourNumber%10;
       Console.WriteLine($"Третья цифра числа = {thirdNumber}");
