/*
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
*/

int num, r, sum=0, t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 && num < 100000)
{
    for(t = num; num != 0; num = num / 10)
    {
        r=num % 10;
        sum=sum*10+r;
    }
    if(t==sum)
        Console.Write($"{t} - является палиндромом.");
    else
        Console.Write($"{t} - не является палиндромом.");
} 
else
    Console.Write("Введите пятизначное число! ");