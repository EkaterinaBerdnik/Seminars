// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


// int SecondNumber(int num)
// {
//     return (num % 100) / 10;
// }
// int randomNumber = new Random().Next(100, 1000);
// Console.WriteLine(randomNumber);
// int result = SecondNumber(randomNumber);
// Console.WriteLine(result);



// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6


// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// void ThirdNumber(int num)
// {
//     if (num < 100)
//     {
//         Console.WriteLine($"{num} -> Третьей цифры нет");
//     }
//     while (num >= 1000) num = num / 10;
//     {
//         if (num >= 100 && num < 1000) num = num % 10;
//         {
//             Console.WriteLine($"Третья цифра {num} ");
//         }
//     }
// }

// ThirdNumber(num);





// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет

// Console.WriteLine("Введите номер дня недели ");
// int num = int.Parse(Console.ReadLine()!);

// if (1 > num || num > 7)
// {
//     Console.WriteLine("Это не номер дня недели!");
// }

// else if (num == 6 || num == 7)
// {
//     Console.WriteLine("Это выходной день!");
// }
// else
// {
//     Console.WriteLine("Это не выходной день!");
// }