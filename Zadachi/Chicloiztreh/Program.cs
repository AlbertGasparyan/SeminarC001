Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int EndOfNumber = number%10;
if((number<100) || (number>999)) Console.WriteLine("Введите трёхзначное число! ");
else
Console.Write(EndOfNumber);