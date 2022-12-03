Console.Clear();
int n, m;
Console.WriteLine("Ведите два числа: ");
n = Convert.ToInt32(Console.ReadLine());
m = Convert.ToInt32(Console.ReadLine());
if (n > m)
{
    Console.WriteLine("{0} наибольшее число", n);
}
else
{
    Console.WriteLine ("{0} наибольшее число", m);
}
Console.ReadLine();