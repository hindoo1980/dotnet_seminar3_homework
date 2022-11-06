// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool CheckPalindrome (int InputDigit)
{
    int d1 = InputDigit / 10000;
    int d2 = (InputDigit / 1000) % 10;
    int d4 = (InputDigit / 10) % 10 ;
    int d5 = InputDigit % 10; 

    if (d1==d5 && d2==d4)
    {
        return (true);
    }
    else
    {
        return (false);
    }
}

Console.WriteLine("Input five-digit number: ");
int fivedigit = Convert.ToInt32(Console.ReadLine());

if (fivedigit < 10000 || fivedigit > 99999 )
{
    Console.WriteLine($"entered value {fivedigit} is not a five-digit number");
}
else
{
    if ( CheckPalindrome(fivedigit) )
    {
    Console.WriteLine($"entered five-digit number {fivedigit} is palindrome");
    }
    else
    {
    Console.WriteLine($"entered five-digit number {fivedigit} is not palindrome");
    }
}
