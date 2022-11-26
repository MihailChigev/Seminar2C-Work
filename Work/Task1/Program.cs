// Напишите программу которая выводит случайное число из отрезка [10_________90] и показывает наибольшию цифру числа
//78 -> 8
//12 -> 2
//85 -> 8 

Console.Clear();
int randomDigit = new Random().Next(10, 100);
Console.WriteLine("Случайное число " + randomDigit);

int ostatok = randomDigit%10;
Console.WriteLine("Последняя цифра случайного числа:  " + ostatok);

int firstDigit = randomDigit/10;
Console.WriteLine("Первая цифра случайного числа:   " + firstDigit);

/*int maxDigit = 0;
if (ostatok > firstDigit) 
    maxDigit = ostatok;
else maxDigit = firstDigit;

Console.WriteLine("Наибольшая цифра числа:  " + maxDigit);
*/
 int maxDigit = firstDigit;

 if (ostatok > firstDigit)
     maxDigit = ostatok; 
 
 else
 Console.WriteLine("Наибольшая цифра числа:  " + maxDigit);
