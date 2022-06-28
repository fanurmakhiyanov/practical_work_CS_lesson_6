// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int prompt(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] numbers(int countM)
{
    int[] MNumbers = new int[countM];
    for (int i = 0; i < countM; i++)
    {
        MNumbers[i] = prompt($"Введите число {i + 1} из {countM}");
    }
    return MNumbers;
}
int PositiveNumbers(int[] array)
{
    int counter = 0;
    foreach (int elm in array)
    {
        if (elm > 0) counter++;
    }
    return counter;
}

int M = prompt("Введите необходимое количество чисел: ");
int[] myNumbers = numbers(M);
Console.WriteLine($"Количество положительных чисел среди введеных: {PositiveNumbers(myNumbers)}");

