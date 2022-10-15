Console.Clear();
String [] days = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};

Console.WriteLine("Введите число от 1 до 7: ");

int NumberOfDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(days[NumberOfDay-1]);
