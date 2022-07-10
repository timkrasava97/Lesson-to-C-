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