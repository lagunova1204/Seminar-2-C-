int InputSecondNumber(int number)
{
    int count;
    count = number % 100 / 10;
    return count;
}

Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = InputSecondNumber(number);
Console.WriteLine($"Вторая цифра {number} : {secondNumber}");