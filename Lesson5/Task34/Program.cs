void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

printInConsoleWithColor("Введите длинну массива: ",ConsoleColor.DarkBlue);
int userArrayLength = Convert.ToInt32(Console.ReadLine());

int[] getRandomArray(int userArrayLength, int startPoint, int endPoint)
{
    int[] resultArray = new int[userArrayLength];
    for (int i = 0; i < userArrayLength; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for(int i = 0; i < incomingArray.Length; i++)
    {
      Console.Write(incomingArray[i]);  
      if(i < incomingArray.Length - 1)
      {
        Console.Write(",")  ;  
      }
    }
    Console.WriteLine("]");
}
int getEvenNumbersInArray(int[] incomingArray)
{
    int count = 0;
    for(int i = 0; i < incomingArray.Length; i++)
    {  
      if(incomingArray[i] % 2 == 0)
      {
        count += 1;     
      }
    }
    return count;
}

int [] currentArray = getRandomArray(userArrayLength, 99, 999);
printArray(currentArray);

int EvenNumbersInArray = getEvenNumbersInArray(currentArray);

printInConsoleWithColor($"Колличество четных чисел в массиве равно : {EvenNumbersInArray}",ConsoleColor.DarkMagenta);
