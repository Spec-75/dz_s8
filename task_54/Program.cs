// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8



Console.WriteLine("enter the dimension of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("source array");
int[,] matrix = new int[n, n];
int[,] sortMatrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(-1, 10);
        sortMatrix[i, j] = matrix[i, j];        
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
int[] bufer = new int[n];

Console.WriteLine("sorted array: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    bufer[j] = sortMatrix[i, j];
    Array.Sort(bufer);
    for (int k = 0; k < n; k++)
    {
        sortMatrix[i, k] = bufer[k];
        Console.Write(sortMatrix[i, k]  + "\t");
    }
    Console.WriteLine();
}