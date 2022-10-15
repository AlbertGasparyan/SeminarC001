Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
//Находим квадрат числа
int sqr = number * number;
Console.Write($"Квадрат числа {number} равна {sqr}");