// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


Console.Clear();
Console.WriteLine("Введите желаемое кол-во элементов массива N ");
Console.Write(" N =  ");
int n = Convert.ToInt32(Console.ReadLine());

double[] num = new double[n];

SetArrayRealNumbers(num);

void SetArrayRealNumbers(double[] num)
{
  for (int i = 0; i < n; i++)
  {   
        num[i] = new Random().Next(- 1000,1000);
  } 
}
Console.Write(String.Join(", ", num));
Console.WriteLine();

double min = num[0];
double max = num[0];

for (int i = 0; i < n; i++)
{
    if (num [i] >= max)
    {
       max =  num[i];
    }
    else if( num[i] <= min)
    {
        min = num[i];
    }
}
Console.WriteLine($" В данном массиве разница между максимальным ({max}) и минимальным ({ min})");
Console.Write($"элементом с учетом знака будет равна max - min  = {max - min}");
