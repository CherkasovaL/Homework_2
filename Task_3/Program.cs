// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int DayOfWeek = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkOrHoliday(DayOfWeek));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkOrHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write(+ a + " - Да");
        }
        else
        {
            Console.Write(+ a + " - Нет");
        }
    }
    else
    {
        Console.Write("Введено неверное число");
    }
return "";
}