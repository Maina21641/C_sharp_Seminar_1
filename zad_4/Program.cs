// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// System.Console.Write("Введите число:   ");
// string N = Console.ReadLine();
// int endNumber = Convert.ToInt32(N);
// int Number = endNumber * (-1); // умножаем на отрицательную единицу, чтобы отсчет пошел с минус N
// System.Console.Write($"{Number} ");

// while (Number < endNumber)
// {
//     Number++;
//     System.Console.Write($"{Number} ");
// }
// System.Console.WriteLine(); System.Console.WriteLine();

// В семинаре задача решена проще.

Console.WriteLine ("Введите число");
int N = int.Parse (Console.ReadLine());

for (int i = -N; i < N + 1; i++)
{
    Console.Write(i + " ");
}