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
int getMaxNumberInArray(int[] incomingArray)
{
    int MaxNumber = 0;
    for(int i = 0; i < incomingArray.Length; i++)
    {  
      if(incomingArray[i] > MaxNumber)
      {
        MaxNumber = incomingArray[i];     
      }
    }
    return MaxNumber;
}
int getMinNumberInArray(int[] incomingArray)
{
    int MinNumber = 999;
    for(int i = 0; i < incomingArray.Length; i++)
    {  
      if(incomingArray[i] < MinNumber)
      {
        MinNumber = incomingArray[i];     
      }
    }
    return MinNumber;
}

int [] currentArray = getRandomArray(userArrayLength, 99, 999);
printArray(currentArray);

int MaxNumberInArray = getMaxNumberInArray(currentArray);
int MinNumberInArray = getMinNumberInArray(currentArray);
int DiffOfNumbersMaxAndMin = MaxNumberInArray - MinNumberInArray;

printInConsoleWithColor($"Максимальное число в массиве : {MaxNumberInArray}",ConsoleColor.DarkMagenta);
printInConsoleWithColor($"Минимальное число в массиве : {MinNumberInArray}",ConsoleColor.DarkMagenta);
printInConsoleWithColor($"Разница Максимально и Минимального чисел : {DiffOfNumbersMaxAndMin}",ConsoleColor.DarkMagenta);