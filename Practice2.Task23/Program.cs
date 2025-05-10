Console.WriteLine("Напишите год: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.Write((year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? "Високосный" : "Невисокосный");