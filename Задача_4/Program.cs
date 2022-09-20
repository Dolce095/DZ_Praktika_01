// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите число 1, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2, ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3, ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.Write("Число 1 - максимальное. \n\n");
        }
        else
        {
            Console.Write("Число 3 - максимальное. \n\n");
        }
    }
    else if (num2 > num3)
        Console.Write("Число 2 - максимальное. \n\n");
    else
        Console.Write("Число 3 - максимальное. \n\n");
