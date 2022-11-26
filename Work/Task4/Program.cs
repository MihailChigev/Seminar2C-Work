//Напишите программу котора принимает на вход число и проверяет кратно ли оно одовременно 7 и 23
// 14 - нет
// 46 - нет
// 161 - да

Console.Clear();
Console.WriteLine("Введите число:  ");
int number = int.Parse(Console.ReadLine());
 if (number % 7 == 0 & number % 23 == 0)
 {
    Console.WriteLine(" - да");
    
 }
else 
{
    Console.WriteLine(" - нет ");
}
