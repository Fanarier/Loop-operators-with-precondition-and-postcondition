//Плотников Кирилл 22-ИСП-2/2
//Варивнт: 6,98
//Гражданин 1 марта открыл счет в банке, вложив 1000руб. Через каждый ме-сяц размер вклада увеличивается на 2% от имеющейся суммы. Определить:а)за  какой  месяц  величина  ежемесячного  увеличения  вклада  превысит 30руб.;б)через сколько месяцев размер вклада превысит 1200руб

double pay = 1000;
int pay_1 = 1000;

for (int i = 1; i <= 10; i++)
{
pay = (pay * 0.02) + pay;
if (pay - pay_1 >= 30)
{
Console.WriteLine("Величина ежемесячного увеличения вклада превысила 30 руб.");
}
if (pay >= 1200)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Размер вклада превысил 1200 руб.");
Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Через " + i + " месяц деньги стали: " + pay);
Console.ResetColor();
}

Console.ReadKey();