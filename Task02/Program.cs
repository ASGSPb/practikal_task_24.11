// //Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.



Console.Clear();
Console.WriteLine("Введите желаемое кол-во элементов массива N ");
Console.Write(" N =  ");
int n = Convert.ToInt32(Console.ReadLine());

int[] num = new int[n];

SetOneDimensionalArray(num);

void SetOneDimensionalArray(int[] num)
{
  for (int i = 0; i < n; i++)
  {   
        num[i] = new Random().Next(1,1000);
  } 
}
Console.Write(String.Join(", ", num));
Console.WriteLine();

int sumOdd = 0;

for (int i = 1; i < n; i++)
{
    if (i % 2 != 0)
    {
        sumOdd = sumOdd + num[i];
    }
}
Console.WriteLine($" В данном массиве сумма элементов стоящих на нечетных позициях равна {sumOdd}");

