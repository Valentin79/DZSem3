//  Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string n = Console.ReadLine();

int len = n.Length; 
int i = 0;

while (i < len/2)
{
    if (n[i] != n[len - i - 1])
        {
        Console.WriteLine("no");
        break;
        
        }
    i++;
    if(i == len/2) Console.WriteLine("yes"); 
}
