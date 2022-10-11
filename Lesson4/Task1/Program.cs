void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int Exponentiation(int firstNumber, int secondNumber)
{
    int result = 1;
    for(int i=1; i <= secondNumber; i++) 
    {
        result = result * firstNumber;
    }
    return result;
}
printInConsoleWithColor($"Введите число,которое хотите возвести в степень:",ConsoleColor.DarkBlue);
int firstNumber = Convert.ToInt32(Console.ReadLine());
printInConsoleWithColor($"Введите степень:",ConsoleColor.DarkBlue);
int secondNumber = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(firstNumber, secondNumber);
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равняется {exponentiation}");
