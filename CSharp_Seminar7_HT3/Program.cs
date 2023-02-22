// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// пеяать массива построчно с форматированием
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}  ");
        }
        Console.WriteLine();
    }
}

//  среднее арифметическое элементов столбцов массива c округлением до 2 знаков после запятой
double [] NumbsAverage (int [,] array)
{
    double [] average = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           sum = sum + array[i, j];
          
        }
        average [j] = Math.Round (sum / array.GetLength(0), 2);
        //  округляем до 2 знаков после запятой
    }
    return average;
}

int m = ConsoleInputInt ("Введите количество строк в массиве: ");
int n = ConsoleInputInt ("Введите количество столбцов в массиве: ");
int d1 = ConsoleInputInt ("Введите начало диапазона чисел в массиве: ");
int d2 = ConsoleInputInt ("Введите конец диапазона: ");
// задаём массив (m x n) элементов в диапазоне от d1 до d2
int [,] matrix = FillArrayInt (m, n, d1, d2); 
PrintArray (matrix);
Console.WriteLine ($"Среднее арифметическое каждого столбца: [{string.Join ("; ", NumbsAverage (matrix))}] ");