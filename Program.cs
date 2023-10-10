int SecondDigit(int number)
{
    return number / 10 % 10;
}

string ThirdDigit(string number)
{
    if (number.Length < 2)
        return "третьей цифры нет";
    return Convert.ToString(number[2]);
}

string isWeekend(int number)
{
    if (number == 6 || number == 7)
        return "Да";
    return "Нет";
}

int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigit(firstNumber));

string secondString = Console.ReadLine();
Console.WriteLine(ThirdDigit(secondString));

int thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isWeekend(thirdNumber));