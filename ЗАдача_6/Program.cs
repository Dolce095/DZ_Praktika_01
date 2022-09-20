// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без
// остатка).
Console.Clear();
Console.Write("Введите число, ");
int i = Convert.ToInt32(Console.ReadLine());
if (i % 2 == 0)
{
    Console.Write("Введенное число является четным");
    Console.Read();
}
else
{
    Console.Write("Введенное число нечетное");
    Console.Read();
}