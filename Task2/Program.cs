// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Write number: ");
int num= Convert.ToInt32(Console.ReadLine());
int result = 0;
if (num / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int count = 0;
    int original_num = num;
    while (num!= 0)
    {
        num=num/10;
        count++;
    }
    result = original_num/Convert.ToInt32(Math.Pow(10,count-3))%10;
    Console.WriteLine(count);
    Console.WriteLine(result);
}