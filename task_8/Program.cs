//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Запрос ввода переменных
Console.WriteLine("Программа выводит все четные числа. (для выхода введите 0)");
Console.WriteLine("Введите число (от 1 до N):");
int num = 0;

while (true)
{
	// Получение числа
	if (!Int32.TryParse(Console.ReadLine(), out num))
	{
		Console.WriteLine("Не число!"); continue;
	}

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
