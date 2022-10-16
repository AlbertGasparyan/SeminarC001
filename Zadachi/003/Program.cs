Console.Clear();
Console.Write("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2==0) Console.WriteLine("Число чётное");
else
if(number%2==1) Console.WriteLine("Число нечётное");