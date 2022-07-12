void quandrant ()
{
    int number1 = 5 ;
  int number2 = 25 ;
if (number2 == number1 * number1 )
    Console.WriteLine (number1 + " является квадратом числа " + number2) ;
else
   Console.WriteLine (number1 + " не является квадратом числа " + number2);
     }       // создание процедуры
//int number1 = Convert.ToInt32(Console.ReadLine()) конвертирует тип данных  string > 

/*Console.WriteLine ("Введите число от 1 до 7" );
int day = Convert.ToInt32(Console.ReadLine());

if ( day == 1 )
  Console.WriteLine("Пондельник");
else if (day == 2)
 Console.WriteLine("вторник");
 else if (day == 3)
  Console.WriteLine("среда");
  else if (day == 4)
  Console.WriteLine("четверг");
  else if (day == 5)
   Console.WriteLine("пятница");
    else if (day == 6)
  Console.WriteLine("Суббота");
  else if (day == 7)
   Console.WriteLine("Воскресуха");
   else 
   Console.WriteLine("указанно некорректное число");
   Console.WriteLine(day);*/

   // Создаем функцию
    
 
 /*Console.WriteLine("введите число");
 int num = Convert.ToInt32(Console.ReadLine()) ;
 int result = Power(num);
 Console.WriteLine(result);*/
 
 
 
 int Power(int currentNumber)   // это функция
 {
    return currentNumber*currentNumber;  //тело функции 
 }
 
 quandrant();  // это вызов процедуры
 

 /*
Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);             // задача 
int once = number % 10;
int tens = number / 100;
Console.WriteLine(tens*10+once);*/

/*
Console.WriteLine("введите значение 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение 2");
int number2 = Convert.ToInt32(Console.ReadLine());
int ost = number2%number1;
if (ost == 0)
 Console.WriteLine(number1 + " " + number2 + "кратно");
 else
 Console.WriteLine(number1 + " " + number2 + " не кратно, остаток " + ost);*/




        Console.WriteLine("введите значение 1");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите значение 2");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2 * number2 || number2 == number1 * number1);
           Console.WriteLine("является квадратом");
        else
           Console.WriteLine(" не является квадратом");




/*
void ex13()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());    

    int hungs=(a/100)%10;
    if (hungs==0) Console.WriteLine("Третьей цифры нет");
    else 
    {
        Console.WriteLine("Третья цифра:");
        Console.WriteLine(hungs);
    }
}

void ex15()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a==1)
        Console.WriteLine("Понедельник");
    else if (a==2)
        Console.WriteLine("Вторник");
    else if (a==3)
        Console.WriteLine("Среда");
    else if (a==4)
        Console.WriteLine("Четверг");
    else if (a==5)
        Console.WriteLine("Пятница");
    else if (a==6)
        Console.WriteLine("Суббота");
    else if (a==7)
        Console.WriteLine("Воскресенье");
    else
        Console.WriteLine("Не день недели");

    if (a>5 && a<8) Console.WriteLine("Выходной");
    else if (a<8) Console.WriteLine("Будний");
}

*/
   