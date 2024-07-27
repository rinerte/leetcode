//Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
public int AddDigits(int num)
{
    while (num > 9)
    {
        num = num / 10 + num % 10;
    }
    return num;
}