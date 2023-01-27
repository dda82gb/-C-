// Задача 8: Напишите программу, которая на вход принимает 
// число (N),а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());

int numberN = 2;

if(number1 > 1)
{
    while(numberN <= number1)
    {
        Console.Write(numberN + ", ");
        numberN = numberN + 2;
    }
}