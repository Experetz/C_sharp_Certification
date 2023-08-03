/* Даны два положительных целых числа, представленных в виде строк. 
Необходимо получить сумму чисел, которые представлены этими строками. 
Причем полученная сумма должна быть преобразована в строку.

Для решения этой задачи запрещено преобразовывать входные строки 
сразу напрямую в целое число при помощи встроенной функции. 
Необходимо сделать это самостоятельно.

Пример 1:
Входные значения: num1 = "11", num2 = "123"
Результат: "134"

Пример 2:
Входные значения: num1="456", num2 = "77"
Результат: "533"

Пример 3:
Входные значения: num1 = "0", num2 = "0"
Результат: "0"
*/

//Methods

int ConvertStringToInt(string str)
{
    int result = 0;
    for(int i = 0; i < str.Length; i++)
    {
        int temp = str[i] - '0';
        result += temp * Convert.ToInt32(Math.Pow(10,str.Length-1-i));
    }
    Console.WriteLine(result);
    return result;
}

string SummAndConvert(int num1, int num2)
{
    return Convert.ToString(num1 + num2);
}

//----------------------------------------------------------------------

string num1 = "0";
string num2 = "11";
Console.WriteLine("The sum of your numbers is " + SummAndConvert(ConvertStringToInt(num1),ConvertStringToInt(num2)));
