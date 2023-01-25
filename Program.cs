//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

Console.Write("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++)
{
    result *= a;
}
Console.WriteLine(result);

*/

/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine("Сумма цифр в числе: " + sum);

*/

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void Array(int[] array)
{
    Console.Write("Ваш массив: [");
    
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetArray(length);
Array(userArray);