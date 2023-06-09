//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// Запрос и ввод переменных
Console.WriteLine("Введите 3 числа:");
int[] num = new int[3];

// Получение и преобразование типов
for (int i = 0; i < 3; i++) {
    num[i] = Convert.ToInt32(Console.ReadLine()!);
}

// дополнительные переменные
int max = num[0], min = num[0];
string outStr = "";

// Цикл нахождения максимального и минимального
for (int i = 1; i < 3; i++) 
{
    if (min > num[i]) { min = num[i]; }
    if (max < num[i]) { max = num[i]; }
}

// Формирование строки
for (int i = 0; i < 3; i++)
{
    outStr += num[i] + ", ";
}

// Вывод в консоль.
Console.WriteLine($"{outStr} max = {max}, min = {min}");