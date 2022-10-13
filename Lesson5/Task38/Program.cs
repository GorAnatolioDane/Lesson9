void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

printInConsoleWithColor("Введите длинну массива: ", ConsoleColor.DarkBlue);
int userArrayLength = Convert.ToInt32(Console.ReadLine());

double[] arrayRealNumbers = new double[userArrayLength];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 999);
    Console.Write(arrayRealNumbers[i] + " ");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}

double decision = maxNumber - minNumber;

printInConsoleWithColor($"\nРазница между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}", ConsoleColor.DarkMagenta);