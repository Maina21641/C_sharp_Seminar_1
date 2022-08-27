// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// 1 вариант с Рандомным числом
// System.Console.WriteLine();

// int number = new Random().Next(100, 1000);

// System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");
// System.Console.WriteLine();

// 2 вариант с Введением числа вручную из семинара

Console.WriteLine ("Введите 3-х значное число: ");
int threeN = int.Parse (Console.ReadLine());
Console.WriteLine ($"Последняя цифра числа {threeN} - " + threeN % 10); // + здесь отвечает за присоединение