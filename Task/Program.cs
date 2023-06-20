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

//РЕШЕНИЕ 1 (с использованием двух массивов)
Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}

Console.WriteLine();
PrintArray(arrayFinal);

// РЕШЕНИЕ 2 (с использованием одного массива)

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
int len = 3;
int pos = 0;

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());

    if (element.Length <= len)
    {
        arrayStrings[pos] = element;
        pos++;
    }
}

Console.WriteLine();
PrintArray(pos);


//______________________________________

void PrintArray(int length)
{
    string temp = "[";
    for (int i = 0; i < length; i++)
        temp += i == 0 ? arrayStrings[i] : "," + arrayStrings[i];   
    temp += "]";
    Console.WriteLine(temp);
}
