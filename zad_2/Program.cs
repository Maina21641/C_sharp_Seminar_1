//Написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

System.Console.WriteLine("Введите первое число: ");
string writeNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(writeNumber1);

// На семинаре 4-я и 5-я строка были объединены в одну строку:
// int number1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
string writeNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(writeNumber2);

// На семинаре 11-я и 12-я строка были объединены в одну строку:
// int number2 = int.Parse(Console.ReadLine());

string txtResult = $"Число {number1} не является квадратом числа {number2}";     // вывод результата проверки на экран
// TxtResult - это элемент управления TextBox - (текстовое окно) предназначено для хранения текста (одной или нескольких строк). 
// На семинаре 17-я строка выглядела иначе:
// int sq = Convert.ToInt32(Math.Pow(number2, 2));

if (number1 == number2 * number2) // можно записать (number1 == sq) или (number1 / number2 == number2)
{
    txtResult = txtResult.Replace(" не", "");   // если условие выполняется, то частица "не" заменяется пустым значением
}
System.Console.WriteLine(txtResult);
System.Console.WriteLine();

// На семинаре с 24-й строки код выглядел короче:
// {    
// Console.WriteLine($"{number1} является квадратом {number2}");
// }  
// else
// {
// Console.WriteLine($"{number1} НЕ является квадратом {number2}");
// }