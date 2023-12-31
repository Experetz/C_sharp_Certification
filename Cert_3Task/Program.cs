﻿/*Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. 
Определите, является ли ваша строка допустимой.
Исходная строка считается допустимой при условии:
1. Открытые скобки должны быть закрыты скобками того же типа.
2. Открытые скобки должны быть закрыты в правильном порядке.
4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

Пример 1:
Входная строка: s = "()"
Результат: true

Пример 2:
Входная строка: s = "()[]{}"
Результат: true

Пример 3:
Входная строка: s = "(]"
Результат: false

Пример 4:
Входная строка: s = "()[]{()}"
Результат: true
*/


bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
//Пробуем все варианты приведенные в примерах. 

        string s1 = "()";
        string s2 = "()[]{}";
        string s3 = "(]";
        string s4 = "()[]{()}";

        Console.WriteLine(IsValid(s1)); 
        Console.WriteLine(IsValid(s2)); 
        Console.WriteLine(IsValid(s3)); 
        Console.WriteLine(IsValid(s4)); 

