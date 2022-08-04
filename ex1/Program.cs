// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Решение без цикла

// Console.WriteLine("введите число, которое хотите возвести");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число, которое примет значение степени");
// int B = Convert.ToInt32(Console.ReadLine());
// int reesult = 1;
// if (B == 0) Console.WriteLine("Ответ: "+result);
// else
// {
// int i = Convert.ToInt32(Math.Pow(A, B));
// result = i;
// Console.WriteLine("Ответ: "+result);
// }


Console.WriteLine("введите число, которое хотите возвести");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число, которое примет значение степени");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i=1; i <= B; i++)
    {
        result = result * A;  
    }
Console.WriteLine("Ответ: "+result);
    





