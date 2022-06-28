// Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада
// увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

double money = 1000;

Console.WriteLine("Enter month quantity: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n + 1)
{
    money = money + money * 0.015;
    count++;
}
Console.WriteLine(money);
