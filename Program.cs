Console.WriteLine("Введите a и b через пробел");
string[] input = Console.ReadLine().Split(" ");
double a = Convert.ToDouble(input[0]);
double b = Convert.ToDouble(input[1]);
Console.WriteLine("Введите количество разбиений интеграла N");
StreamWriter sw = new StreamWriter("C:\\Users/prdb/Desktop/JDJD/task6/file.txt");
int N = Convert.ToInt32(Console.ReadLine());
if (b <a)
{
    Console.WriteLine("Ошибка b должно быть больше a");
}
double h = (b - a) / N;

static double Fun(double x)

{
    return 2*Math.Pow(x, 2)+3*x;
}

static double func(double a, double b, double h, int N,double answ)
{

    for (int i = 0; i <= N; i++)
    {
        answ += a + i * (h / 2);
        
    }
    return answ * h;
}
double wert = func(a, b, h, N, 0);
sw.WriteLine($"Интеграл от {a} до {b} = {wert:F3}");
Console.WriteLine($"Интеграл от {a} до {b} = {wert:F3}");
sw.Close();
