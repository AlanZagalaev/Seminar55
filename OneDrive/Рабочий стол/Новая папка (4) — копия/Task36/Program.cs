﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = {-4, -6, 89, 6};

int sum = 0;
for (int i = 1; i < numbers.Length; i += 2)
{
    sum += numbers[i];
}

Console.WriteLine("Сумма элементов: " + sum);
