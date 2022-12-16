/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

void FillArray (int [] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(100, 1000);
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

int i = 0;
int count = 0;
while(i < 4)
{
    if (0 == arr[i] % 2)
    {
        count = count + 1;
    }
    i++;
}
Console.WriteLine();
Console.WriteLine(count);


/*
int i = 0;
int sum = 0;

while(i < 4)
{
    int N = new Random().Next(100, 999);
    if(0 == N % 2)
    {
        array [i] = N;
        i = i + 1; 
        sum = sum + N;
    }
}
for(i=0; i < 10; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write(sum);
*/