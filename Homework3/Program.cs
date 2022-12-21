// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int palindrom = number.Length;

if (palindrom == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine(number + " -> это палиндром");
    }

    else
    {
        Console.WriteLine(number + " -> это не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное значное число!");
}





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Coordinats(double x, double y, double z, double x1, double y1, double z1)
{
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2) + Math.Pow((z - z1), 2)), 2));
}
Console.WriteLine("input x=");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input y=");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input z=");
double z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input x1=");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input y1=");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input z1=");
double z1 = Convert.ToDouble(Console.ReadLine());

Coordinats(x, y, z, x1, y1, z1);





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void kube(int N)
{
    for (int index = 1; index <= N; index++)
    {
        Console.Write($"{index * index * index}, ");
    }
    if (N < 1)
    {
        Console.WriteLine("Вы ввели неправильное значение!");
    }
}
Console.WriteLine("Введите число N: ");
int x = Convert.ToInt32(Console.ReadLine());
kube(x);