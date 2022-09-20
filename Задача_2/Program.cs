// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите число 1, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2, ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
    {
            Console.Write("Число 1 - максимальное. \n\n");
        }
        else
        {
            Console.Write("Число 2 - максимальное. \n\n");
        }
     