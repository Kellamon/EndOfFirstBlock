string[] NewArray = new string[3] { "Hello", "222", "World" };
string[] CompareArray = new string[NewArray.Length];

void Compare(string[] NewArray, string[] CompareArray)
{
    int count = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i].Length <= 3)
        {
            CompareArray[count] = NewArray[i];
            count++;
        }
        else
            Console.WriteLine($"{i + 1}й не соответсвует ТЗ");
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Compare(NewArray, CompareArray);
PrintArray(CompareArray);