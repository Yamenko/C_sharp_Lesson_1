//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Запрос ввода переменных
using System;

Console.WriteLine("Программа выводит все четные числа. (для выхода введите 0)");
Console.WriteLine("Введите число (от 1 до N):");

while (true)
{
	// Получение числа
	try { 
		int num = Convert.ToInt32(Console.ReadLine());

		// выход по условию
		if (num == 0) { break; }

		// если меньше 0, то ждем другое число
		if (num < 0) { continue; }

		// Формирование стороки
		int tmp = 2;
		string outStr = "";
		while (num >= tmp) {
			outStr += Convert.ToString(tmp) + ", ";
			tmp += 2;
		}

		// Вывод в консоль.
		Console.WriteLine($"Число: {num}, четные: {outStr}");
    }
	// защита от ввода не числа!
    catch (Exception e)
    {
        Console.WriteLine("Не число!");
    }
}
