/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int Sum(int number)
{
    int result = 0;
    int number1 = number;
    while (number1 >0)
    {
        number1 = number1 / 10;
        result = result + number % 10;
        number = number1;
    }
    return result;
}

int number = GetNumber("Введите число");
int sum = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");