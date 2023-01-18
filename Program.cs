// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

Console.Clear();
Console.WriteLine("Данная программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символа.");
Console.WriteLine();

string[] CreateStrArray()
{
    Console.Write("Введите количество элементов в массиве: ");
    string[] arrayStr = new string[int.Parse(Console.ReadLine())];

    for (int i = 0; i < arrayStr.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        arrayStr[i] = Console.ReadLine();
    }
    return arrayStr;
}

string[] Create3SymblArray(string[] mainArray)
{
    int count = 0;
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (mainArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] array3Symbl = new string[count];

    count = 0;

    for (int i = 0; i < mainArray.Length; i++)
    {
        if (mainArray[i].Length <= 3)
        {
            array3Symbl[count] = mainArray[i];
            count++;
        }
    }
    return array3Symbl;
}

void PrintArray(string[] arrayForPrint)
{
    if (arrayForPrint.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < arrayForPrint.Length - 1; i++)
        {
            Console.Write($"“{arrayForPrint[i]}“, ");
        }
        Console.Write($"“{arrayForPrint[arrayForPrint.Length - 1]}“]");
    }
    else Console.Write("[]");
}

string[] arrMain = CreateStrArray();
string[] arr3Symb = Create3SymblArray(arrMain);

Console.WriteLine();
PrintArray(arrMain);
Console.Write(" → ");
PrintArray(arr3Symb);
Console.WriteLine();