System.Console.OutputEncoding = System.Text.Encoding.UTF8;
bool check1;
bool check2;
uint num = 0;
uint d = 0;
do
{
    Console.Write("Введите натуральное число: ");
    check1 = UInt32.TryParse(Console.ReadLine(), out num);
    Console.Write("Введите натуральное число, чтоб найти количество делителей больше этого числа: ");
    check2 = UInt32.TryParse(Console.ReadLine(), out d);
} while (check1 == false || check2 == false);
long summ = 0;
long summOfEven = 0;
uint countEven = 0;
uint countOdd = 0;
uint countD = 0;
Console.WriteLine($"Делители числа {num}: ");
for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(i);
        summ = summ + i;
        if (i % 2 == 0)
        {
            countEven += 1;
            summOfEven = summOfEven + i;
        }
        else if (i % 2 == 1)
        {
            countOdd += 1;
        }
        if (i >= d)
        {
            countD += 1;
        }
    }
}
Console.WriteLine($"Сумма делителей равна: {summ}");
Console.WriteLine($"Сумма чётных делителей равна: {summOfEven}");
Console.WriteLine($"Количество чётных делителей равно: {countEven}");
Console.WriteLine($"Количество нечётных делителей равно: {countOdd}");
Console.WriteLine($"Количество всех делителей равно: {countEven + countOdd}");
Console.WriteLine($"Количество всех делителей больше второго ввёденного вами числа {d} равно: {countD}");

