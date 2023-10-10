int SecondDigit(int number)
{
    return number / 10 % 10;
}

string ThirdDigit(int number)
{
    if (number / 100 == 0)
        return Convert.ToString(number / 100 % 10);
    return "третьей цифры нет";
}

string isWeekend(int number)
{
    if (number == 6 || number == 7)
        return "Да";
    return "Нет";
}