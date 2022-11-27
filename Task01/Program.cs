// Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите желаемое кол-во элементов массива N ");
Console.Write(" N =  ");

int n = Convert.ToInt32(Console.ReadLine());

int[] num = SetArrayThreeDigitNumbers(n);

Console.Write(String.Join(", ", num));
Console.WriteLine();
Console.WriteLine();

int even = 0;

for (int i = 0; i < n; i++)
{
    if (num[i] % 2 == 0)  
    {
      even = even + 1;
    }
    
}
Console.WriteLine($" В данном массиве {even} четных чисел");
Console.WriteLine();

int[] SetArrayThreeDigitNumbers(int n)
{
    int[] num = new int[n];

    for (int i = 0; i < n; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
    return num;
}
