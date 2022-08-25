﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine($"\nДанная программа посчитает количество положительных чисел, которые пользователь введёт с клавиатуры.\n");
Console.Write("Введите целое положительное число, обозначающее общее количество вводимых чисел: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count = 0;
for (int i = 0; i < numM; i++)
{
    Console.Write($"Введите любое целое число {i + 1}: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"\nПоложительных чисел: {count}\n");

