int SecondDigit(int number)
{
    return number / 10 % 10;
}

string ThirdDigit(int number)
{
    if (number / 100 == 0)
        return "третьей цифры нет";
    return Convert.ToString(Convert.ToString(number)[2]);
}

string isWeekend(int number)
{
    if (number == 6 || number == 7)
        return "Да";
    return "Нет";
}

int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigit(firstNumber));

int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit(secondNumber));

int thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isWeekend(thirdNumber));