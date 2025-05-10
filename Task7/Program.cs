
Console.Write("Метр: ");
double metr = Convert.ToDouble(Console.ReadLine());

double kilometr = metr / 1000;
Console.WriteLine("Километр=  "+kilometr);
Console.WriteLine(  );


Console.Write("Километр: ");
double km = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сантиметров: "+ km *100000); // в  км сколько см
Console.WriteLine();

Console.Write("м/с: ");
double  mc = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("км/ч: " + mc * 3.6); // м/с в км/ч
Console.WriteLine();


Console.Write("Градусы Цельсия: ");
double с1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Фаренгейт: " + (с1 * 9.0 / 5.0 + 32)); // градусы C в градусы F 
    // C = 5 / 9 *(F - 32)
    // F=C*(9/5)+32
