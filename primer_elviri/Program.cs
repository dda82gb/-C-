Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

int max = firstNumber;
int min = secondNumber;

if(firstNumber < secondNumber)
{
max = secondNumber;
min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
