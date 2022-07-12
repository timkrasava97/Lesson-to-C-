void zadacha1()
{
Console.WriteLine("введите значение 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение 2");
int number2 = Convert.ToInt32(Console.ReadLine());
  if (number1>number2)
    Console.WriteLine("значение " + number1 + " > значения " + number2);
  else if (number1<number2)
   Console.WriteLine("значение " + number2 + " > значения " + number1); 
   else 
   Console.WriteLine("значения равны"); 
}

void zadacha2()
{
Console.WriteLine("введите три числа поочередно через Enter");
int numbers = Convert.ToInt32(Console.ReadLine()) ;
int numbers2 = Convert.ToInt32(Console.ReadLine()) ;
int numbers3 = Convert.ToInt32(Console.ReadLine()) ;
int max = numbers;
if (numbers2 > max)

     max = numbers2;
// else по началу писал сюда и не мог понять почему не работает. долго же думал
 if (numbers3 > max)

     max = numbers3;

Console.WriteLine(max);
}

void zadacha3()
{
Console.WriteLine("введите число");
int numbers = Convert.ToInt32(Console.ReadLine());
int sum = numbers % 2;
 if (sum<1)
  Console.WriteLine("четное число");
 else 
 Console.WriteLine("нечетное число"); 
}
void zadacha4 ()
{
Console.WriteLine("введите число");
int numbers = Convert.ToInt32(Console.ReadLine());
int curr = 1;
while (curr <= numbers)
{
if (curr % 2 == 0)    
Console.WriteLine(curr);
curr++;
}
}  




// zadacha1();
// zadacha2();
// zadacha3();
// zadacha4();