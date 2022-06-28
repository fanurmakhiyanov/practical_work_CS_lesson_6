// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double prompt(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double[] FindTheIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        double[] except = new double[1];
        if (b1 == b2)
        {
            except[0] = 1;
            return except;
        }
        else
        {
            return except;
        }
    }
    double[] answer = new double[2];
    answer[0] = (b2 - k1) / (k1 - k2);
    answer[1] = k1 * answer[0] + b1;
    return answer;
}

void ResultInterpretator(double[] result, double k1, double b1, double k2, double b2)
{
    if (result.Length == 1)
    {
        if (result[0] == 0) Console.WriteLine("There is no crossing between lines");
        else { Console.WriteLine("Both lines are the same"); }
    }
    else
    {
        Console.WriteLine($"The point of interseption of lines y = {k1}x+{b1} and y = {k2}x+{b2} is ({result[0]:f2}, {result[0]:f2})");
    }
}

double k1 = prompt("Define the coefficient k1 in y=k1*x+b1 for the first line: ");
double b1 = prompt("Define the coefficient b1 in y=k1*x+b1 for the first line: ");
double k2 = prompt("Define the coefficient k2 in y=k2*x+b2 for the first line: ");
double b2 = prompt("Define the coefficient b2 in y=k2*x+b2 for the first line: ");
ResultInterpretator(FindTheIntersection(k1,b1,k2,b2),k1,b1,k2,b2);