// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

////System.Console.WriteLine();
////string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// Квадратные скобки ([]) используются для массивов, индексаторов и атрибутов.
// Дней 7. Массив состоит из 7 ячеек.

////System.Console.Write("Введите номер дня недели:   ");
////string writeDay = Console.ReadLine();
////bool result = int.TryParse(writeDay, out int dayNumber);

// Ключевое слово типа bool — это псевдоним для типа структуры System.Boolean .NET, представляющий логическое значение: true или false.

////System.Console.WriteLine();
////if (result == false) System.Console.WriteLine("Число введено неверно");
////else if (0 < dayNumber && dayNumber < 8) System.Console.WriteLine($"{dayNumber}-й день недели - {Days[dayNumber - 1]}");

// предложение сложное для восприятия и понимания

////else System.Console.WriteLine("Дня недели с таким номером не существует");
////System.Console.WriteLine();

// В семинаре были два других варианта:
// 1 вариант. (если убрать знаки $, то алгоритм все равно будет работать. Я не понимаю его значение здесь!!!)

////Console.WriteLine ("Введите число от 1 до 7: ");

////int number = int.Parse (Console.ReadLine());

////if (number == 1)
////{
    ////Console.WriteLine ($"Понедельник");
////}
////else if (number == 2)
////{
    ////Console.WriteLine ($"Вторник");
////}
////else if (number == 3)
////{
    ////Console.WriteLine ($"Среда");
////}
////else if (number == 4)
////{
    ////Console.WriteLine ($"Четверг");
////}
////else if (number == 5)
////{
    ////Console.WriteLine ($"Пятница");
////}
////else if (number == 6)
////{
   //// Console.WriteLine ($"Суббота");
////}
////else if (number == 7)
////{
    ////Console.WriteLine ($"Воскресенье");
////}
////else
////{
    ////Console.WriteLine ($"Вы ввели не то число!!!");
////}

// 2 вариант.

string[] arr = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine ("Введите число от 1 до 7: ");

int number = int.Parse (Console.ReadLine());

if (number > 7 || number < 1) // знак "||" означает "ИЛИ"
{
    Console.WriteLine("Вы ввели не то число!!!");
}
else
{
    Console.WriteLine($"{number}-й день недели - {arr[number -1]}"); // указываем на массив, от введенного числа отнимаем 1, чтобы код вывел индекс
}
//здесь знак $ нужен, иначе консоль выводит {number}-й день недели - {arr[number -1]}