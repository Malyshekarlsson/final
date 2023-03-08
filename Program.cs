// Массив из строк. Показать значения с 3 и менее символами

Console.WriteLine("Введите количество значений, которые хотите внести");
int NumQ = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[NumQ];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите {i+1}-е значение ");
    arr[i] = Convert.ToString(Console.ReadLine());
}
Console.WriteLine("Значения с 3-мя и менее символами");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        Console.WriteLine(arr[i]);
    }
    else
    {
        Console.ReadLine( );
    }
}
Console.WriteLine();

