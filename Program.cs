using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть перше число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введіть друге число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введіть дію (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

int result = 0; 

    switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
}

Console.WriteLine("Результат: " + result);
    }
}