/*Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

Пример 1:
Исходный массив: [1, 2, 1, 1, 4]
Результат: 12115 (целое число).
Объяснение: если мы пройдем по элементам массива слева-направо, то последовательность элементов представляет из себя число 12004. Дальше мы плюсуем к этому числу 1 и получаем 12115

Пример 2:
Исходный массив: [1, 1, 2, 9]
Результат: 1130
Объяснение: если мы пройдем по массиву слева-направо, то получим число 1129. Прибавляем к данному числу 1 и получаем 1130.

Пример 3:
Исходный массив: [9]
Результат: 10. */

// Methods
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] GetDoubleArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
double GetNumber(int[] array)
{
    double sum = 0;
    int NumPow = 0;
    for (int i = array.Length - 1; i > -1; i--)
    {
        sum = sum + array[i] * Math.Pow(10, NumPow);
        NumPow++;
    }
    return sum;
}
//------------------------------------------------------------
int length = Prompt("Put your array length");
int[] array = GetDoubleArray(length);
PrintIntArray(array);
double sum = GetNumber(array);
Console.WriteLine($"The number you are seeking is {sum + 1}");