// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[]  {};
arrayStrings = new string[n];
for (int i = 0; i < arrayStrings.Length; i++)
{
  Console.Write($" Введите {i+1} строку: ");
  arrayStrings[i] = Console.ReadLine();
}

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int temp = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[temp] = oldArray[i];
      temp++;
    }
  }
}

int CheckArray(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

int lengthLimit = 3;

int numbersItems = CheckArray(arrayStrings, lengthLimit);

string[] newArrayStrings = new string[numbersItems];

FillNewArray(arrayStrings, newArrayStrings, lengthLimit);
Console.WriteLine($"{PrintArray(newArrayStrings)}");
