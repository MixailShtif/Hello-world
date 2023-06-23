Console.Clear();//отчистка экрана
Console.WriteLine("Введите число => ");//Вывод приглашения
string inputedValue = Console.ReadLine();//ввод пользователя (строки)
int number = Convert.ToInt32(inputedValue);//Преобразует строку в целое число
Console.WriteLine("Вы ввели число " + number);

int square = number * number;// вычесление квадрата
Console.WriteLine("квадрат числа " + square);//вывод результата

