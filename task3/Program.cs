// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76


void FillArrayRandomNumbers(double[] temp)
{
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void CheckNum(double[] temp)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int i = 0; i < temp.Length; i++)
    {
        if (temp[i] > max)
        {
            max = temp[i];
        }
        if (temp[i] < min)
        {
            min = temp[i];
        }
    }
    Console.WriteLine($"Всего {temp.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}

double[] FillArrayWithRandomNumbers()
{
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] temp = new double[size];
FillArrayRandomNumbers(temp);
Console.WriteLine("массив: ");
PrintArray(temp);
return temp;
}

double[] mass = FillArrayWithRandomNumbers();
CheckNum(mass);

