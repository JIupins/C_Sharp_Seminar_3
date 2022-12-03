// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

void DefineRowOfCubes(int num)
{
    int count = 1;
    while(count <= num)
    {
       double result =  Math.Pow(count,3);
       Console.Write ($"{result}, ");
       count += 1;
    }
}

Console.WriteLine($"Введите число, для определения кубов чисел от 1 до данного числа: ");
int number = Convert.ToInt32(Console.ReadLine());

DefineRowOfCubes(number);