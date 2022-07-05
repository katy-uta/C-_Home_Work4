/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

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

int Stepen(int number, int st)
{
    int result = 1;

    for (int i = 1; i <= st; i++)
    {
        result = result * number;
    }
    return result;
}

int A = GetNumber("Введите первое число: ");
int B = GetNumber("Введите второе число: ");

int result = Stepen(A, B);
Console.WriteLine($"{A} в степени {B} = {result}");
