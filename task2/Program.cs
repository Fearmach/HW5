// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0


void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(" ", arr) + "]");
}

void RandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}

int[] FillArrayWithRandomNumbers()
{
    Console.WriteLine("Введите размер массива:  ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    RandomNumbers(arr);
    Console.WriteLine("массив: ");
    PrintArray(arr);
    return arr;
}


void CheckNum(int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 1)
        sum += mass[i];      
    }
    Console.WriteLine ($"Всего {mass.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
}

int[] mass = FillArrayWithRandomNumbers();
CheckNum(mass);
