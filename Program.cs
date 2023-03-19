//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//РЕШЕНИЕ ЗАДАЧИ СПИСАЛ. С РАЗВОРОТОМ ЧИСЛА БЫЛИ ВСЕГДА ПРОБЛЕМЫ КАК И ТУТ.
/*
Console.WriteLine ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Палиндром");
    }

    else
    {
        Console.WriteLine(number + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}

*/
//Задача_23 Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
/*
РЕШЕНИЕ ВЫПОЛЕНО С ПОМОЩЬЮ РЕШЕНИЯ ЗАДАЧИ НА СЕМИНАРЕ
void GetTable(int n)
{
    int i = 1;
    while(i <= n)
    {
        System.Console.WriteLine($"{i} {Math.Pow(i, 3)}");
        i++;
    }
}
System.Console.Write("Введит чило N: ");
int n = Convert.ToInt32(Console.ReadLine());

GetTable(n);
*/

//Задача_21
// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.


// НИЖЕ ПРЕДСТАВЛЕНЫ РЕШЕНИЯ НА ОСНОВЕ ЗАДАЧИ КОТОРУЮ МЫ СДЕЛАЛИ НА ЗАНЯТИИ И ВТОРАЯ-СПИСАНАЯ 
/*
void Distance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2)); 

    System.Console.WriteLine($"Расстояние между двумя точками = {result}");
}

double Input(string message)
{
    System.Console.Write($"Введите {message}: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double x1 = Input("x1");
double y1 = Input("y1");
double x2 = Input("x2");
double y2 = Input("y2");
double z1 = Input("z1");
double z2 = Input("z2");

Distance(x1, y1, x2, y2, z1, z2);
*/

/*
Console.WriteLine("\n Задача 21");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
*/
