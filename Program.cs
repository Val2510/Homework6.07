//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}


void Sorting2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        bool swap = true;
        while (swap == true) {
            swap = false;
            for (int j = array.GetLength(1)-1; j >= 0 ; j--) {
                if (j-1 < 0) {
                    continue;
                }
                if (array[i, j] > array[i, j-1]) {
                    (array[i, j], array[i, j-1]) =  (array[i, j-1],  array[i, j]);
                    swap = true;
                } 
            }
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
Sorting2DArray(myArray);
Print2DArray(myArray);*/

//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void SumLine(int[,] array)
{
    int sum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp > sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка c минимальной суммой: " + index);

}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Console.WriteLine();
Print2DArray(myArray);
Console.WriteLine();
SumLine(myArray);
*/


//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
/*
int a = InputNum("Введите число строк 1-й матрицы: ");
int b = InputNum("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = InputNum("Введите число столбцов 2-й матрицы: ");
int range = InputNum("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[a, b];
Create2DArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
Fill2DArray(firstMartrix);

int[,] secondMartrix = new int[b, n];
Create2DArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
Fill2DArray(secomdMartrix);

int[,] resultMatrix = new int[a, n];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение двух матриц:");
Fill2DArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/
/*
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int columns, int len)
{
    return new int[rows, columns, len];
}

void Fill3DArray(int[,,] array, int min, int max)
{
    int val = 10;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int m = 0; m < array.GetLength(2); m++)
            {
                array[i, j, m] = val;
                val++;
            }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i, j, m]} ({i},{j},{m})\t");
            }
    Console.WriteLine();
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int len = InputNum("Введите длину массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,,] myArray = Create3DArray(rows, cols, len);
Fill3DArray(myArray, minValue, maxValue);
Print3DArray(myArray);
Console.WriteLine();
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int a = 4;
int[,] array = new int[a, a];

void SpiralArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int temp = 1;
    int iBeg = 0;
    int iFin = 0;
    int jBeg = 0;
    int jFin = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i == iBeg && j < array.GetLength(1) - jFin - 1)
            j++;
        else if (j == array.GetLength(1) - jFin - 1 && i < array.GetLength(0) - iFin - 1)
            i++;
        else if (i == array.GetLength(0) - iFin - 1 && j > jBeg)
            j--;
        else
            i--;

        if ((i == iBeg + 1) && (j == jBeg) && (jBeg != array.GetLength(1) - jFin - 1))
        {
            iBeg++;
            iFin++;
            jBeg++;
            jFin++;
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

SpiralArray(array);
Print2DArray(array);
*/