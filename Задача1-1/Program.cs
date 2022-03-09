//  Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.


Console.Write("Введите число:");
string n = Console.ReadLine();
string str = n.ToString();
int[] array = new int[str.Length];
int j = 0;
while(j < str.Length)
{
    array[j] = int.Parse(str[j].ToString());
    j++;
}


int i = 0;
if(str.Length < 2) Console.WriteLine("Число должно иметь хотя бы два разряда");
while (i < str.Length/2)
{
    if (array[i] != array[str.Length - i - 1])
        {
        Console.WriteLine("no");
        break;
       
        }
    i++;
    if(i == str.Length/2) Console.WriteLine("yes"); 
}
