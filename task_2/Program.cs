//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Запрос и ввод переменных
Console.WriteLine("Введите 2 числа:");
string? numStr_1 = Console.ReadLine();
string? numStr_2 = Console.ReadLine();

// Преобразование типов
int num1 = Convert.ToInt32(numStr_1);
int num2 = Convert.ToInt32(numStr_2);

// Сравнение и вывод в консоль.
if (num1 == num2)       { Console.WriteLine($"num1 = {num1}, num2 = {num2}, они равны!"); }
else if (num1 > num2)   { Console.WriteLine($"num1 = {num1}, num2 = {num2}, max = {num1}, min = {num2}"); }
else                    { Console.WriteLine($"num1 = {num1}, num2 = {num2}, max = {num2}, min = {num1}"); }