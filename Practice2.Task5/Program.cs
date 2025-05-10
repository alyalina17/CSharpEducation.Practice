int a=Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine($"{a} больше {b}");
else if (b > a) Console.WriteLine($"{b} больше {a}");
else Console.WriteLine($"{a} равно {b}");