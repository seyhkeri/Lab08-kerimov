// // PrintHeader("Отчет");
// // PrintHeader("Отчет2");

// // static void PrintLine() 
// // {
// //     Console.WriteLine("^_^");
// // }
// // static void PrintHeader(string title)
// // {
// //     PrintLine();
// //     Console.WriteLine(title);
// //     PrintLine();
// // }

// // int result1 = Max(5, 10);
// // Console.WriteLine(result1);
// // int result2 = Max(25, -3);
// // Console.WriteLine(result2);
// // int result3 = Max(7, 7);
// // Console.WriteLine(result3);

// // Console.WriteLine(even(4));
// // Console.WriteLine(even(7));
// // Console.WriteLine(even(0));

// // static int Max(int a, int b)
// // {
// //     return a > b ? a : b;
// // }

// // static bool even(int n)
// // {
// //     return n % 2 == 0;
// // }

// // int[] arr = { 120, 45, 300, 80, 15, 210 };
// // Console.WriteLine(Average(arr));
// // Console.WriteLine(Count(arr, 100));

// // static double Average(int[] arr)
// // {
// //     double sum = 0;
// //     foreach (int x in arr)
// //     {
// //         sum += x;
// //     }
// //     return sum / arr.Length;
// // }

// // static int Count(int[] arr, int limit)
// // {
// //     int count = 0;
// //     foreach (int x in arr)
// //     {
// //         if (x > limit)
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }

// // double c1 = 0;
// // double f1 = fahrenheit(c1);
// // Console.WriteLine($"{c1} °C = {f1} °F");
// // double c2 = 100;
// // double f2 = fahrenheit(c2);
// // Console.WriteLine($"{c2} °C = {f2} °F");
// // double c3 = 37;
// // double f3 = fahrenheit(c3);
// // Console.WriteLine($"{c3} °C = {f3} °F");

// // static double fahrenheit(double cels)
// // {
// //     return cels * 9 / 5 + 32;
// // }

// Console.WriteLine(factorial(5));
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine();
// int num1 = positive("Введите 1 положительное число: ");
// int num2 = positive("Введите 2 положительное число: ");
// Console.WriteLine(num1 + num2);

// static int factorial(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//         {
//             result *= i;
//         }
//     return result;
// }

// static bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0) return false;
//     }
//     return true;
// }

// static int positive(string message)
// {
//     int value = 0;
//         while (value <= 0)
//         {
//             Console.Write(message);
//             value = Convert.ToInt32(Console.ReadLine());
//         }
//         return value;
// }

do
{
    Console.WriteLine("\n1 - сумма двух чисел");
    Console.WriteLine("2 - большее из двух чисел");
    Console.WriteLine("3 - факториал");
    Console.WriteLine("0 - выход");
    Console.Write("Выберите пункт: ");
    string input = Console.ReadLine();

    if (input != "1" && input != "2" && input != "3" && input != "0")
    {
        Console.WriteLine("Нет такого пункта.");
        continue;
    }

    switch (input)
    {
        case "1":
            int a1 = ReadPositive("Введите 1 положительное число: ");
            int b1 = ReadPositive("Введите 2 положительное число: ");
            Console.WriteLine($"Сумма: {Sum(a1, b1)}");
            break;
        case "2":
            int a2 = ReadPositive("Введите 1 положительное число: ");
            int b2 = ReadPositive("Введите 2 положительное число: ");
            Console.WriteLine($"Большее число: {Max(a2, b2)}");
            break;
        case "3":
            int n = ReadPositive("Введите положительное число для факториала: ");
            Console.WriteLine($"Факториал {n}! = {Factorial(n)}");
            break;
        case "0":
            Console.WriteLine("Выход из программы.");
            return;
    }
} while (true);

static int ReadPositive(string message)
{
    int value;
    do
    {
         Console.Write(message);
        value = Convert.ToInt32(Console.ReadLine()); 
    } while (value <= 0);
    return value;
}

static int Sum(int a, int b)
{
    return a + b;
}

static int Max(int a, int b)
{
    return a > b ? a : b;
}

static int Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

// Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}");
// Console.WriteLine($"Gcd2(4, 6) = {Gcd2(4, 6)}");

// static int Gcd(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;
//     }
//     return a;
// }

// static int Gcd2(int a, int b)
// {
//     return a / Gcd(a, b) * b;
// }
