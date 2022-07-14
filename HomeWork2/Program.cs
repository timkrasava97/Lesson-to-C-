// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Zadacha1()
{
Console.WriteLine("Введите трехзначное число");
int num =  Convert.ToInt32(Console.ReadLine());
int ones = num / 10 % 10;
Console.WriteLine(ones); 
}
void Zadacha1_Doubl2()  
{
Console.WriteLine("Введите трехзначное число");
int nums = Convert.ToInt32(Console.ReadLine());
string strNum = Convert.ToString(nums);
Console.WriteLine("вторая цифра числа это " + strNum[1]);
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Zadacha2()  // тут я подглядел в интернете. других вариантов не пришло больше в голову, так как числа могуг состоять из множества цифр
{
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else 
{
  Console.WriteLine(anyNumberText + " -> третьей цифры нет");
}
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Zadach3()
{
Console.Write("Введите число дня недели  ");
int NumDay = Convert.ToInt32(Console.ReadLine());
if (NumDay >= 1 && NumDay < 6)
   Console.WriteLine(NumDay + " -> сегодня будний день");
else if (NumDay < 1 || NumDay > 7)
   Console.WriteLine("Неправильно заданно число. В недели всего 7 дней");
else Console.WriteLine(NumDay + " -> выходной");      
}




// Zadacha1();
// Zadacha1_Doubl2();
// Zadacha2();
// Zadach3();