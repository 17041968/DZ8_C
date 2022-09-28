//Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
//Напишите программу, которая будет построчно выводить массив.

int[,] array = new int[3, 3];
FillArray(array);
PrintIndex(array);

void PrintIndex(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}

void FillArray(int[,] arr)
{
	int count = 10;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = new Random().Next(1, 10);
			arr[i, j] += count;
			count += 1;
		}
	}
}