//Напишите программу которая выводит случайное 3-х значное число и удаляет вторую цифру этого числа 
// 456 - 46
// 782 - 72
// 918 - 98

Console.Clear();
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine("Случайное трехзначное число число: " + randomNumber);
/*
int result = (randomNumber/100) * 10 + randomNumber%10;//короткий способ
Console.WriteLine(randomNumber + "->" + result );
*/
int firstDigit = randomNumber/100;
Console.WriteLine("Первая цифра случайного числа:   " + firstDigit);//выводм первую цифру 3-х значного числа

int ostatok = randomNumber%10;
Console.WriteLine("Последняя цифра случайного числа:  " + ostatok);// выводим третью цифру 3-х значного числа 

Console.WriteLine("2-х значное число: " + firstDigit+ostatok );
