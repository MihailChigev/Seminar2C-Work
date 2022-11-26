//Напишите программу которая будет принимать на вход два числа и выводить является ли второе число кратное первому
//Если число 2 не кратно числу 1 то программа выводит остаток от деления 
//35, 5 - не кратно, остаток 4
//16 ,4 - кратно

Console.Clear();
Console.WriteLine("Введите первое число:  ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int number2 = int.Parse(Console.ReadLine());

if (number1%number2 == 0)
{
    Console.WriteLine (" число " + number2+ " является кратным " + number1);
}

else
{
    int ostatok = number1 % number2;
    Console.WriteLine("Число " + number2 + " Не является крытным числу " + number1 + " остаток " + ostatok);
}  
   
   

 
   
  
