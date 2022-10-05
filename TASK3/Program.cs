//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Введите целое число от 1 до 7");
var number = Console.ReadLine();

int numberInt;
    bool badIncome = int.TryParse(number, out numberInt);
    if ( badIncome)
    {
        Console.WriteLine("Молодец, это число!");
    }
    else
    {
        Console.WriteLine("Это число не целое, или это и не число вовсе. Попробуйте еще разочек от 1 до 7 !");
        return;

    }
 int ourNumber = Convert.ToInt32(number);   
 if (ourNumber < 0 || ourNumber >= 8 )
 {
    Console.WriteLine("Вы ошиблись, попробуйте еще разочек: от 1 до 7");
    return;
 }
 else
 {
    string[]  weekDays = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    Console.WriteLine($"Сегодня {weekDays[ourNumber-1]}!");

 }