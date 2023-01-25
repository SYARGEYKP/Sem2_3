// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int daynumber = InputInt("Введите номер дня недели");
if (daynumber > 7)
{
    System.Console.WriteLine("это не день недели");
}
else
{
    if (daynumber == 7 || daynumber == 6)
    {
        System.Console.WriteLine("Выходной");
    }

    else
    {
        System.Console.WriteLine("Рабочий");
    }

}


