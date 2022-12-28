// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] NewArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
        Console.Write(myArray[i] + " ");
    }
    return myArray;
}

void ChetElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    count++;
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] Array = NewArray(lenght);
ChetElements(Array);





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] NewArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(-99,100);
        Console.Write(myArray[i] + " ");
    }
    return myArray;
}
void SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    sum = sum + array[i];
    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {sum}");
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] Array = NewArray(lenght);

SumElements(Array);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = 10;
double[] myArray = new double[size];
{
    
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Convert.ToDouble(new Random().Next(1,1000)) / 100;
    }
    Console.WriteLine();
}

void ShowArray(double[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}

double[] newArray = myArray;

ShowArray(newArray);
MinMaxDifference(newArray);