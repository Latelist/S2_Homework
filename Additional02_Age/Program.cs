/* На вход подаются год, номер месяца и день рождения человека.
Определить возраст человека на момент 1 июля 2022 года. */


Console.WriteLine("Enter year of birth: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter month of birth: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter day of birth: ");
int day = Convert.ToInt32(Console.ReadLine());

int age = 0;

if (month < 7)
{
    age = 2022 - year;
}
else
{
    age = 2022 - year - 1;
}

Console.WriteLine(age); 