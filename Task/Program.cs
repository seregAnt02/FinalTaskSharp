/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

// РЕШЕНИЕ 

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
int len = 3;
int pos = 0;

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());

    if (element.Length <= len)
    {
        array[pos] = element;
        pos++;
    }
}

Console.WriteLine();
PrintArray(pos);


//______________________________________

void PrintArray(int length)
{
    for (int i = 0; i < length; i++)
    {        
        Console.Write("длинна меньше либо равна 3 символа: " + array[i] + "\r\n");
    }
    Console.WriteLine();
}
