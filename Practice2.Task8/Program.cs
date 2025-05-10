double a=Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
if (a == b || a == c || b == c)
{   a += 5;
    b += 5;
    c += 5;

    Console.WriteLine($"{a}\n{b}\n{c}");
}
else
    Console.WriteLine("равных нет");