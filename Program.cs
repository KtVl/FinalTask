// Задача: 
// Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма.
//    При решении не рекомендуется пользоваться коллекциями,
//     лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Вводные данные
string[] arrayStr = new string[] { "hello", "2", "world", ":-)" };
// string[] arrayStr = new string[] { "1234", "1567", "-2", "computer science" };
// string[] arrayStr = new string[] { "Russia", "Denmark", "Kazan" };
int doesNotExceed = 3;
System.Console.WriteLine("Исходный массив строк: ");
PrintArray(arrayStr);

string[] arrayDoesNotExceedThreeSymbols = GetArrayDoesNotExceedThreeSymbols(arrayStr, doesNotExceed);
System.Console.WriteLine("Сформированный массив строк: ");
PrintArray(arrayDoesNotExceedThreeSymbols);


string[] GetArrayDoesNotExceedThreeSymbols(string[] array, int maxLengthStr)
{
    int current = 0;
    string[] arrayTemp = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthStr)
        {
            arrayTemp[current] = array[i];
            current++;
        }
    }
    string[] arrayFinal = new string[current];
    for (int j = 0; j < current; j++)
    {
        arrayFinal[j] = arrayTemp[j];
    }
    return arrayFinal;
}

void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        System.Console.Write("[ ");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write($"{array[i]}, ", 4);
        }
        System.Console.Write($"{array[array.Length - 1]}", 4);
        System.Console.WriteLine(" ]");
    }
    else System.Console.WriteLine("[ ]");
}
