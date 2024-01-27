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
Random random = new Random();
if (size <= 3)
{
	if (size > 0)
	{
		for (int i = 0; i < size; i++)
		{
			int index = random.Next(array.Length);
			arr[i] = array[index];

		}
		PrintArray(arr);
	}
	else
	{
		Console.WriteLine("[]");
	}
}
else
{
	Console.Write("Неверная длина массива");
}