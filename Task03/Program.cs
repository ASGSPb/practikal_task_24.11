// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


Console.Clear();
Console.WriteLine("Введите желаемое кол-во элементов массива N ");
Console.Write(" N =  ");
int n = Convert.ToInt32(Console.ReadLine());

double[] num = SetArrayRealNumbers(n);

double min = num[0];
double max = num[0];

for (int i = 0; i < n; i++)
{
    if (num[i] >= max)
    {
        max = num[i];
    }
    else if (num[i] <= min)
    {
        min = num[i];
    }
}

Console.Write(String.Join("; ", num));

Console.WriteLine();

Console.WriteLine($" В данном массиве разница между максимальным ({max}) и минимальным ({min})\n элементом с учетом знака будет равна max - min  = {Math.Round((max - min), 2)}");

 double[] SetArrayRealNumbers (int n)
{
    double[] num = new double[n];

    for (int i = 0; i < n; i++)
    {
        num[i] = new Random().Next(100, 1000) + new Random().NextDouble();

        num[i] = Math.Round(num[i], 2);
    }
    return num;
}


