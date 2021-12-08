Console.WriteLine("Введите значение радиуса:");
MyDelegate myDelegate = Сircumference;
if (myDelegate!=null)
{
    double D = myDelegate(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Длина окружности равна {0}",D);
}
Console.WriteLine();
Console.WriteLine("Введите значение радиуса:");
MyDelegate myDelegate2 = AreaCircle;
if (myDelegate2 != null)
{
    double S = myDelegate2(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Площадь круга равна {0}", S);
}
Console.WriteLine();
Console.WriteLine("Введите значение радиуса:");
MyDelegate myDelegate3 = SphereVolume;
if (myDelegate3 != null)
{
    double V = myDelegate3(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Объём шара равен {0}", V);
}

static double Сircumference(double R)
{
    double D = 2 * R * Math.PI;
    return D;
   
}
static double AreaCircle(double R)
{
    double S = R * R * Math.PI;
    return S;
    Console.WriteLine(S);
}
static double SphereVolume(double R)
{
    double V = 4 / 3 * R * R * R * Math.PI;
    return V;
    Console.WriteLine(V);
}
delegate double MyDelegate(double R);


