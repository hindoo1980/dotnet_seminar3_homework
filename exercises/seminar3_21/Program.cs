// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistCalc (int ax, int ay, int az, int bx, int by, int bz)
{
return Math.Sqrt(((bx-ax)*(bx-ax))+((by-ay)*(by-ay))+((bz-az)*(bz-az)));
}

Console.WriteLine("Input x coordinate of point А: ");
string tmp1 = Console.ReadLine();
bool check1 = int.TryParse(tmp1, out int ax);

Console.WriteLine("Input y coordinate of point А: ");
string tmp2 = Console.ReadLine();
bool check2 = int.TryParse(tmp2, out int ay);

Console.WriteLine("Input z coordinate of point А: ");
string tmp3 = Console.ReadLine();
bool check3 = int.TryParse(tmp3, out int az);

Console.WriteLine("Input x coordinate of point B: ");
string tmp4 = Console.ReadLine();
bool check4 = int.TryParse(tmp4, out int bx);

Console.WriteLine("Input y coordinate of point B: ");
string tmp5 = Console.ReadLine();
bool check5 = int.TryParse(tmp5, out int by);

Console.WriteLine("Input z coordinate of point B: ");
string tmp6 = Console.ReadLine();
bool check6 = int.TryParse(tmp6, out int bz);

if (check1 && check2 && check3 && check4 && check5 && check6)
{
Console.WriteLine($"distance between A: {ax};{ay};{az} and B: {bx};{by};{bz} is {DistCalc(ax,ay,az,bx,by,bz)}");
}
else
{
Console.WriteLine("wrong input, see you later");
}