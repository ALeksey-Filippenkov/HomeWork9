// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

string NumberTranslation(int numbers)
{
    string result = string.Empty;
    if (numbers > 0)
        return NumberTranslation(numbers / 2) + (numbers % 2);
    else
        return result;
}
System.Console.Write("Enter your numbers: ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers == 0)
    System.Console.WriteLine($"As a result of converting a number to binary , it turns out {numbers}");
else
    System.Console.WriteLine($"As a result of converting a number to binary , it turns out {NumberTranslation(numbers)}");

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


int SumNumbersNM(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + SumNumbersNM(m, n - 1); 
    else return n + SumNumbersNM(m, n + 1);
}
System.Console.Write("Enter your first numbers: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter your second numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
int sumNumbersNM = SumNumbersNM(n, m);
System.Console.WriteLine($"The sum of the sum of natural elements in the range from M to N is equal to {sumNumbersNM}");
