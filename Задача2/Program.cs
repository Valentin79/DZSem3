// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int ax = Prompt("Введите координату Х первой точки: ");
int ay = Prompt("Введите координату Y первой точки: ");
int az = Prompt("Введите координату Z первой точки: ");
int bx = Prompt("Введите координату Х второй точки: ");
int by = Prompt("Введите координату Y второй точки: ");
int bz = Prompt("Введите координату Z второй точки: ");

double result = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2) + Math.Pow(bz-az, 2));

Console.WriteLine(result);