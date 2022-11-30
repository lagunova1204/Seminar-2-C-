Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Не выходной");
        break;
    case 2:
        Console.WriteLine("Не выходной");
        break;
    case 3:
        Console.WriteLine("Не выходной");
        break;
    case 4:
        Console.WriteLine("Не выходной");
        break;
    case 5:
        Console.WriteLine("Не выходной");
        break;
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
                           
    default:
        Console.WriteLine("Такого дня нет");
        break;  
}
