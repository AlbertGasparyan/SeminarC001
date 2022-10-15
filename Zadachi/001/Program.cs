int a = new Random().Next(1,100);
int b = new Random().Next(1,100);

Console.Write("a = ");
Console.WriteLine(a);

Console.Write("b = ");
Console.WriteLine(b);

int max = a;

if(b>max) max=b;
Console.Write("max = ");
Console.WriteLine(max);
