/*Задача 1.
Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
Ваша задача вывести на экран максимальное количество следующих друг за другом 1.

Пример 1:
Исходный массив: [1, 1, 0, 1, 1, 1]
Результат: 3
Объяснение: в данном массиве две последовательности из 1: первые две единицы
в самом начале и последние три единица в конце. Максимальное количество единиц в этих последовательностях 3.

Пример 2:
Исходный массив: [1, 0, 1, 1, 0, 1]
Результат: 2

Пример 3:
Исходный массив: [1, 0, 1, 0, 0, 0, 1]
Результат: 0
Объяснение: в массиве нет следующих друг за другом единиц.*/




/* int GetSequenceOfOnes(int[] array)
    {
        int count = 0;
        int maxCount = 0;

for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1)
        {
            count++;
            if (count > maxCount)
            {
                maxCount = count;
            }
        }
        else
        {
            if (count > 0)
            {
                count = 0;
            }
        }
    }
    return maxCount;
}

 int[] array = { 1, 0, 1, 0, 0, 0, 1 };
 int maxCount = GetSequenceOfOnes(array);
 Console.WriteLine(maxCount);  */ 

 /*int[] array = {1, 0, 1, 0, 0, 0, 1};
        int maxCount = 0;
        int currentCount = 0;
        
        foreach (int num in array)
        {
            if (num == 1)
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 0;
            }
        }
        
        Console.WriteLine("Quantity of sequences ones is: " + maxCount);*/

/*int[] array = { 1, 1, 0, 1, 1, 1 };
        
        int maxCount = 0;
        int currentCount = 0;
        bool isInSequence = false;
        
        foreach (int num in array)
        {
            if (num == 1)
            {
                if (isInSequence)
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                    isInSequence = true;
                }
                
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                isInSequence = false;
            }
        }
        
        Console.WriteLine("The quantity of sequenced ones in array is: " + maxCount);*/
        

