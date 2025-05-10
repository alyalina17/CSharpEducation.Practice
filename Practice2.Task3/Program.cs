// Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a +b)
double a =Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double f = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(a==0 ? "error" : ((a + b - f / a) + f * a * a - (a + b)));





