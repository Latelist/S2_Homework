// Дано натуральное число, в котором все цифры различны. 
// Определить, какая цифра расположена в нем левее: максимальная или минимальная.

/* Я не смогла перевести число в массив цифр, поэтому решила так */


Console.WriteLine("Введите натуральное число, в котором все цифры различны: ");
int natural = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 10;
int number = 0;
int count = 0;
int indexmin = 0;
int indexmax = 0;

while (natural > 0)
{
    number = natural % 10;
    
    if (number > max)
    {
        max = number;
        indexmax = count;
    }
    if (number < min)
    {
        min = number;
        indexmin = count;
    }
    natural = natural / 10;
    count++;
}

if (indexmax < indexmin)
{
    Console.WriteLine("Левее находится минимальная цифра");
}
else
{
    Console.WriteLine("Левее находится максимальная цифра");
}