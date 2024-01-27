void PrintArray(string[] array)
{
	foreach (var item in array)
	{
		Console.Write(item + " ");
	}
}

string[] array = { "Hello", "2", "world", ":-)" };
PrintArray(array);
