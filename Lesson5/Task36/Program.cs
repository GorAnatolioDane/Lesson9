void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

printInConsoleWithColor("Введите длинну массива: ", ConsoleColor.DarkBlue);
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
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int getSumOfOddPositionInArray(int[] incomingArray)
{
    int sumOfOddPosition = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumOfOddPosition = incomingArray[i] + sumOfOddPosition;
        }
    }
    return sumOfOddPosition;
}

int[] currentArray = getRandomArray(userArrayLength, -99, 99);
printArray(currentArray);

int SumOfOddPositionInArray = getSumOfOddPositionInArray(currentArray);

printInConsoleWithColor($"Сумма чисел, стоящих на нечетных позициях : {SumOfOddPositionInArray}", ConsoleColor.DarkMagenta);