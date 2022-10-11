void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

printInConsoleWithColor("Введите длинну массива: ",ConsoleColor.DarkBlue);
int userArrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = new int[userArrayLength];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(1, 99);
}
printArray(array);

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i]);  
      if(i < array.Length - 1)
      {
        Console.Write(",");  
      }
    }
    Console.Write("]");
}


