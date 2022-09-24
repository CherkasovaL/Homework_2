// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(Array(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Array(int NumberA, int NumberB)
{
int result = 0;
    if (NumberB < 3)
    {
        Console.WriteLine("Третьей цифры нет ");
    }
    else
    {
        int NumberC = 1;
        for (int i = NumberB; i > 3; i--)
        {
            NumberC = NumberC * 10;
        }

        result = (NumberA / NumberC) % 10;
    }
return result;
}