// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int N = Prompt("Введите число: ");
int i = 1;
if (N < 0) 
    {
        N = Math.Abs(N);
        while (i <= N)
        {
        Console.WriteLine($"Куб числа -{i} =  {Math.Pow(i,3)*-1}");
        i++;   
        }
    }
while (i <= N)
{
    Console.WriteLine($"Куб числа {i} =  {Math.Pow(i,3)}");
    i++;   
}
