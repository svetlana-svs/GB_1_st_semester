/**************************************
Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
**************************************/

// метод преобразовывает строку, введенную пользователем, в массив
string[] CreateArray (string text)
{
    string[] initialArray = new string[text.Length];
    initialArray = text.Split(" ");
    return initialArray;
}

// метод определяет длину нового массива и создает новый массив
string[] CreateArrayMaxThreeSymbols (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string word = array[i];
        if (word.Length <= 3)
        {
            count++;
        }
    }
 
    string[] finalArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string word = array[i];
        if (word.Length <= 3)
        {
            finalArray[j] = word;
            j++;
        }
    }
    return finalArray;
}

// метод для вывода нового массива
void Print (string[] finalArray)
{
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write($"{finalArray[i]} ");
    }
}
Console.Write("Введите массив, элементы которого разделены через пробел: ");
string text = Console.ReadLine() ??"";
string[] initialArray = CreateArray(text);
Console.WriteLine();
Console.Write("Введенные символы длинной меньше либо равны 3: ");
Print(CreateArrayMaxThreeSymbols(initialArray));