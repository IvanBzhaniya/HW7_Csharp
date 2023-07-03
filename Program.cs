/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9



double [,] Create2Darray ()
{
    Console.WriteLine("enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter count of columns: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double [,] new2dArray = new double [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            new2dArray[i, j] = Math.Round((new Random().Next(userMin, userMax + 1) + new Random().NextDouble()), 2);
        }
    }
    return new2dArray;
}

void Print2DArray( double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] firstTaskArray = Create2Darray();
Print2DArray(firstTaskArray);



Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет



int [,] Create2Darray ()
{

    int [,] new2dArray = new int [3, 4];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            new2dArray[i, j] = new Random().Next(0, 20);
        }
    }    
    return new2dArray;
}

void Print2DArray( int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("input row:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input collumn:");
int col = Convert.ToInt32(Console.ReadLine());

int [,] new2dArray = Create2Darray();
Print2DArray(new2dArray);
if (row >= 4 || col >= 5) Console.WriteLine("такого числа в массиве нет");
else Console.WriteLine(new2dArray[row - 1, col - 1]);


Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

int [,] Create2Darray ()
{

    int [,] new2dArray = new int [3, 4];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            new2dArray[i, j] = new Random().Next(0, 10);
        }
    }
    return new2dArray;
}

void Print2DArray( int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] new2dArray = Create2Darray();
Print2DArray(new2dArray);

double avg1 = (new2dArray[0, 0] + new2dArray[1, 0] + new2dArray[2, 0]) /3.0;
double avg2 = (new2dArray[0, 1] + new2dArray[1, 1] + new2dArray[2, 1]) /3.0;
double avg3 = (new2dArray[0, 2] + new2dArray[1, 2] + new2dArray[2, 2]) /3.0;
double avg4 = (new2dArray[0, 3] + new2dArray[1, 3] + new2dArray[2, 3]) /3.0;
Console.WriteLine($"Среднее арифметическое каждого столбца:{avg1}, {avg2}, {avg3}, {avg4}");
