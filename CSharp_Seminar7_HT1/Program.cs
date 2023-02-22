// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// ввод параметров с консоли и конвертация в Int
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int option = Convert.ToInt32(Console.ReadLine());
    return option;
}

// ввод параметров с консоли и конвертация в Double
double ConsoleInputDbl (string message)
{
    Console.Write(message);
    double option = Convert.ToDouble(Console.ReadLine());
    return option;
}

// создание нового массива и его заполнение
// произвольными вещественными числами в диапазоне от dStart до dEnd 
double[,] FillArrayDouble (int str, int stolb, double dStart, double dEnd)
{
    double[,] arrayNumb = new double [str, stolb];
    for (int i = 0; i < arrayNumb.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumb.GetLength(1); j++)
        {
            arrayNumb[i,j] = new Random().NextDouble(); 
            // определение случайным образом вещественного числа в диапазонне от 0 до 1
            arrayNumb[i,j] = Math.Round(arrayNumb[i,j] * (dEnd - dStart) + dStart, 1);
            // рассширение диапазона до [dStart, dEnd] и округление элементов до 2 знаков после запятой
        }
    } 
    return arrayNumb;
}

// пеяать массива построчно с форматированием
void PrintArray (double[,] array)
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

int m = ConsoleInputInt ("Введите количество строк в массиве: ");
int n = ConsoleInputInt ("Введите количество столбцов в массиве: ");
double d1 = ConsoleInputDbl ("Введите начало диапазона чисел в массиве: ");
double d2 = ConsoleInputDbl ("Введите конец диапазона: ");
// задаём и печатаем массив (m x n) элементов в диапазоне от d1 до d2
PrintArray (FillArrayDouble (m, n, d1, d2)); 

