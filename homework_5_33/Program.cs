/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3.3 7.76 22 2 78.67] -> 76.67 */

void FillArray (double [] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.NextDouble()*100;
    }
}

void PrintArray (double [] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write("{0,6:F2}", array[i]);
    }
}

void FindDifferenceMaxMin (double [] array)
{
    int i = 0;
    double min = array [i];
    double max = array [i];
    while(i < array.Length)
    {
        if(min > array [i])
        {
        min = array [i];
        }
        if(max < array [i])
        {
        max = array [i];
        }
        i++;
    }
    double dif = max - min;
    Console.WriteLine("{0,6:F2}", dif);
}


Console.WriteLine("Введите число элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[N];
FillArray(arr);

PrintArray (arr);
Console.WriteLine();

FindDifferenceMaxMin(arr);
