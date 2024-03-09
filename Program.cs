int max = 3;

string[] array1 = { "Hello", "87", "world", ":-)" };
Solution(array1, max);

string[] array2 = { "1234", "1567", "-2", "computer science" };
Solution(array2, max);

string[] array3 = { "Reactor", "DDR", "USB" };
Solution(array3, max);

int CountElements ( string [] arr, int max)
{
    int count = 0;
    for (nint i = 0; i < arr.Length; i++)
    {
        if ( arr[i].Length <= max)
        count++;
    }
    return count;
}

string [] NewArray (string [] arr, int max)
{
    int newArrayLength = CountElements (arr, max);
    string [] newArray = new string [newArrayLength];
    int newArrayIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i].Length <= max)
        {
            newArray [newArrayIndex] = arr [i];
            newArrayIndex++;
        }
    }    
    return newArray;
}   

