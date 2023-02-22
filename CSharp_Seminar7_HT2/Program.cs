// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// ввод параметров с консоли и конвертация в Int 
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int option = Convert.ToInt32(Console.ReadLine());
    return option;
}
 
// создание нового массива и его заполнение
// произвольными целыми числами в диапазоне от dStart до dEnd 
int [,] FillArrayInt (int str, int stolb, int dStart, int dEnd)
{
    int [,] arrayNumb = new int [str, stolb];
    for (int i = 0; i < arrayNumb.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumb.GetLength(1); j++)
        {
            arrayNumb[i,j] = new Random().Next(dStart, dEnd + 1); 
            // определение случайным образом целого числа в диапазонне [dStart, dEnd]
        }
    } 
    return arrayNumb;
}

//  Преобразование строки ввода (последовательность чисел, 
//  разделенных запятой или пробелом) в числа
int [] InputNumbs (string message)
{
    Console.WriteLine (message);
    string [] numbersEnter = Console.ReadLine().Split (new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    int [] numbers = numbersEnter.Select(Int32.Parse).ToArray();
    return (numbers);
}

int m = ConsoleInputInt ("Введите количество строк в массиве: ");
int n = ConsoleInputInt ("Введите количество столбцов в массиве: ");
int d1 = ConsoleInputInt ("Введите начало диапазона чисел в массиве: ");
int d2 = ConsoleInputInt ("Введите конец диапазона: ");
// задаём массив (m x n) элементов в диапазоне от d1 до d2
int [,] matrix = FillArrayInt (m, n, d1, d2); 
// вводим параметры для поиска
int [] numbs = InputNumbs ("Введите позиции элемента массива (разделяя их запятыми или пробелами):");
if (numbs[0] >= matrix.GetLength(0) || numbs[1] >= matrix.GetLength(1))
{
   Console.Write($"Введенной позиции в массиве {m} x {n} нет");
}
else
{
   Console.Write($"На позиции [{numbs[0]}, {numbs[1]}] в массиве находится число {matrix[numbs[0], numbs[1]]} "); 
}