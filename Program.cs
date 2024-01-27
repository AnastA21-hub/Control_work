void PrintArray(string[] array)
{
	foreach (var item in array)
	{
		Console.Write(item + " ");
	}
}

string[] array = { "Hello", "2", "world", ":-)" };
PrintArray(array);

Console.WriteLine();
Console.Write("Введите длину массива от 0 до 3: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[size];