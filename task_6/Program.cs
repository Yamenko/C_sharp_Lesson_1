﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Запрос и ввод переменных

Console.WriteLine("Программа определения четности числа. (для выхода введите 0)");
Console.WriteLine("Введите число:");

while (true)
{
	try
	{
		int num = Convert.ToInt32(Console.ReadLine());
		string outStr = "";

		// выход по условию
		if (num == 0) { break; }

		// Определение четности
		if ((num % 2) == 0) { outStr = "Четное"; }
		else { outStr = "Не четное"; }

		// Вывод в консоль.
		Console.WriteLine(outStr);
	}
	// защита от ввода не числа!
	catch
	{
		Console.WriteLine("Не число!");
	}
}

