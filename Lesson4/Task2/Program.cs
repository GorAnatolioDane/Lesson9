void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
printInConsoleWithColor("Введите число, в котором нужно посчитать сумму цифр: ", ConsoleColor.DarkBlue);
int userNumber = Convert.ToInt32(Console.ReadLine());
    int SumNumber(int userNumber)
    {
        int counter = Convert.ToString(userNumber).Length;
        int advance = 0;
        int result = 0;
        
        for (int i = 0; i < counter; i++)
        {
            advance = userNumber - userNumber % 10;
            result = result + (userNumber - advance);
            userNumber = userNumber / 10;
        }
        return result;
        
    }

int sumNumber = SumNumber(userNumber);
printInConsoleWithColor("Сумма цифр в числе: " + sumNumber,ConsoleColor.DarkYellow);