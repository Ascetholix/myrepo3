// Факториал

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.Write("Введите число факториала : ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N + 1; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}