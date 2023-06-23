// Выдавать день недели по заданному числу 3 среда, 5 пятница
Console.WriteLine("Введите число");
string Day = Console.ReadLine();
int DayNumber = Convert.ToInt32(Day);
string [] weeks = {"Monday", "Tuesday", "Wendsday", "Thursday", "Friday","Saturday", "Sunday"};
Console.WriteLine(weeks [DayNumber -1]);
