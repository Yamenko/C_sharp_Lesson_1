//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Запрос и ввод переменных
Console.WriteLine("Программа определения четности числа. (для выхода введите 0)");
Console.WriteLine("Введите число:");
int num = 0;
string outStr = "";

while (true)
{
	if (!Int32.TryParse(Console.ReadLine(), out num)){
		Console.WriteLine("Не число!"); continue;
	}

	// выход по условию
	if (num == 0) { break; }

	// Определение четности
	if ((num % 2) == 0) { outStr = "Четное"; }
	else { outStr = "Не четное"; }

	// Вывод в консоль.
	Console.WriteLine(outStr);
}