//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int number = new Random().Next(2, 10);
int power = new Random().Next(2, 5);
int result = Power(number, power);
System.Console.WriteLine($"{number}, {power} -> {result}");

static int Power(int num, int pow)
{
    int count = 1;
    int result = num;

    while(pow > count)
    {
        result *= num;
        count++;
    }

    return result;
}