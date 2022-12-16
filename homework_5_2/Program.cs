/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


void FillArray (int [] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(-99, 100);
    }
}

void PrintArray (int [] array)
{
    for(int i=0; i < 4; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] arr = new int[4];

FillArray(arr);
PrintArray (arr);

int sum = 0;
for(int i = 0; i < 4; i++)
{
    if (0 != i % 2)
    {
        sum = sum + arr [i];
    }
}
Console.WriteLine();
Console.WriteLine(sum);
