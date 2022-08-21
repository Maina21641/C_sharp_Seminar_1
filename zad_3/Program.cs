// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

System.Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// Квадратные скобки ([]) используются для массивов, индексаторов и атрибутов.
// Дней 7. Массив состоит из 7 ячеек.

System.Console.Write("Введите номер дня недели:   ");
string writeDay = Console.ReadLine();
bool result = int.TryParse(writeDay, out int dayNumber);

// Ключевое слово типа bool — это псевдоним для типа структуры System.Boolean .NET, представляющий логическое значение: true или false.

System.Console.WriteLine();
if (result == false) System.Console.WriteLine("Число введено неверно");
else if (0 < dayNumber && dayNumber < 8) System.Console.WriteLine($"{dayNumber}-й день недели - {Days[dayNumber - 1]}");

// предложение сложное для восприятия и понимания

else System.Console.WriteLine("Дня недели с таким номером не существует");
System.Console.WriteLine();