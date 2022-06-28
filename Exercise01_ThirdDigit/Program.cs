/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/



/* Математическое решение

int result = 0;

if (chastitsa < 100)
{
    Console.WriteLine("There is no third digit");
}
else
{
    while (chastitsa > 999)
    {
        chastitsa = chastitsa / 10;
    }
    result = chastitsa % 10;
}
Console.WriteLine(result);
*/

//Решение с переводом в строку
Random rand = new Random();
int chastitsa = rand.Next();
Console.WriteLine(chastitsa);
string digits = chastitsa.ToString();
if (digits.Length < 3) 
{
    Console.WriteLine("There is no third digit");
} 
else 
{
    Console.WriteLine(digits[2]);
}