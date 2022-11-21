// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной");   
}
else 
{
    Console.WriteLine("Это не выходной");
}