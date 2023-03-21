Console.Clear();

string[] array1 = new string[4] { "12345", "2", "wor", "Kazan" };
string[] array2 = new string[array1.Length];

SortArray(array1, array2);
PrintArray(array2);

void SortArray(string[] arr1, string[] arr2)
{
	int idx = 0;
	for (int i = 0; i < arr1.Length; i++)
	{
		if (arr1[i].Length <= 3)
		{
			arr2[idx] = arr1[i];
			idx++;
		}
	}
}

void PrintArray(string[] inArray)
{
	for (int i = 0; i < inArray.Length; i++)
	{
		inArray = inArray.Where(x => x != null).ToArray();
		Console.Write($"{inArray[i]} ");
	}
	Console.WriteLine();
}
