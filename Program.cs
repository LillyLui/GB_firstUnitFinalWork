Console.Clear();
string [] arr1 = {"Hello", "2", "world", ":-)", "Itog", "GB"};
string [] arr2 = new string[arr1.Length];
Console.WriteLine("Первоначальный массив: ");
PrintArr(arr1);
Console.WriteLine("Массив из строк, длина которых меньше или равна 3:");
SearchElement(arr1, arr2);
PrintArr(arr2);

void SearchElement(string[] arr1, string[] arr2)
{
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if (arr1[i].Length <= 3)
      {
      arr2[k] = arr1[i];
       k++;
      }
    }
}

void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
