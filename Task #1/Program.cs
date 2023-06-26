// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число");
string number1 = Console.ReadLine();
Console.WriteLine("введите второе число");
string number2 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
int square = num1 * num1;
if (square == num2)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else 
{
    Console.WriteLine("Второе число не является квадратом первого");
}

