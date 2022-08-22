//на вход принимаем число, а на выход получаем его квадрат

/*Первый вариант
int x;
Console.WriteLine("Введите число: ");
x = Convert.ToInt32(Console.ReadLine());
//x = int.Parse(Console.ReadLine()); = то же самое что и предыдущая запись
int y = x*x;
Console.WriteLine("Result " + (x*x));
Console.Write("result is ");
Console.WriteLine(y);*/

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Result " + MathF.Pow(x,2));

