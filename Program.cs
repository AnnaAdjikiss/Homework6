//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//пример:      0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 3
/*
void FillArray(int arg)
{
    double[] array = new double[arg];
    int count = 0;
	for (int i = 0; i < arg; i++)
	{
		Console.Write("Введите положительное или отрицательное число: ");	
        array[i] = Convert.ToDouble(Console.ReadLine());
		if (array[i] > 0) count++;
    }   
	Console.WriteLine();
	Console.WriteLine($"Количество положительных чисел среди введенных: {count}");
}
Console.WriteLine("Введите количество чисел: ");
int valueM = Convert.ToInt32(Console.ReadLine());
FillArray(valueM);
*/

//Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
//Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

// Пример: 3, 4 ->
//  1 1 1 1
//  1 0 0 1
//  1 1 1 1

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество стoлбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
     for (int j = 0; j < array.GetLength(1); j++)
     {
         if (i == 0 || j == 0 || i == array.GetLength(0)-1 || j == array.GetLength(1)-1 )   array[i, j] = 1;
	     else array[i, j] = 0;
         Console.Write(array[i, j] + " ");
     }
     Console.WriteLine(" ");
}     