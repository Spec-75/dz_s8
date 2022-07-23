// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка


Console.WriteLine("enter the dimension of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("source array");
int minSum = int.MaxValue;
int temp = 0;
int[,] matrix = new int[n, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        sum += matrix[i,j];
    }
    Console.WriteLine();
    //Console.WriteLine(sum);// TODO: проверка расчёта сумм строк
    if (sum < minSum) 
    {
        minSum = sum;
        temp = i;
    }
}
Console.WriteLine($"the smallest sum of elements in rows {minSum}");
Console.WriteLine($"the smallest sum of elements in a row {temp}");