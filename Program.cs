// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите высоту массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] doubleArray = new double [m, n];
Random rnd = new Random();
double [] avarage = new double [n];  
int k = 0;

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i, j] = rnd.Next(0, 10);
        if (k < n)
        {
            avarage[k] = avarage[k] + doubleArray[i,j];
        }
        k = k + 1;
        Console.Write($"{doubleArray[i, j]} ");
    }
    k = 0;

    Console.WriteLine();
}
Console.WriteLine($"Среднее арифметическое каждого столбца равно: ");

foreach (var item in avarage)
{
    Console.Write($"{Math.Round(item/m, 2)} ");
}

