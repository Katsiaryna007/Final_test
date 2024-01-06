string[] array = { "Hello", "2", "world", ":-)" };
string[] newArray = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}
Console.WriteLine("Новый массив: ");
for (int j = 0; j < count; j++) Console.WriteLine(newArray[j]);
