void SecondArrayWithIF(string[] arraysecond, string[] arraytwo)
{
    int count = 0;
    for (int i = 0; i < arraysecond.Length; i++)
    {
        if (arraysecond[i].Length <= 3)
        {
            arraytwo[count] = arraytwo[i];
            count++;
        }
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

Console.Clear();

string[] arraysecond = new string[4] { "hello", "2", "world", ":-)" };
string[] arraytwo = new string[arraysecond.Length];

SecondArrayWithIF(arraysecond, arraytwo);
PrintArray(arraytwo);
