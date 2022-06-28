// Написать программу, которая определяет, является ли треугольник со сторонами a, b, c 
// равнобедренным.


Console.WriteLine("Enter side a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter side b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter side c");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b ^ b == c ^ a == c)
{
    Console.WriteLine("Yes. The triangle is isosceles");
}
else
{
    Console.WriteLine("No. The triangle isn't isosceles.");
}
