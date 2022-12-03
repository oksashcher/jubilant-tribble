Console.Clear();
int a, b, c;
Console.WriteLine("Ведите три числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c);
{
    Console.WriteLine("{0} наибольшее число", a);
}
if (b > a && b > c);
{
    Console.WriteLine("{0} наибольшее число", b);
}
if (c > a && c > b);
{
    Console.WriteLine("{0} наибольшее число", c);
}
Console.ReadLine();