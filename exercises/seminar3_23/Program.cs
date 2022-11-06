// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintlistOfCubes (int inputDigit)
{
   if (inputDigit == 0)
   {
    Console.WriteLine(0); 
   }
   else if (inputDigit > 0)
   {
    for (int i = 1; i <= inputDigit; i++)
    {
        Console.WriteLine(i*i*i);
    }
   }
   else if (inputDigit < 0)
   {
    for (int i = -1; i >= inputDigit; i--)
    {
        Console.WriteLine(i*i*i);
    }
   }
    
}

Console.WriteLine("Input number to output iist of cubes: ");
string tmp = Console.ReadLine();
bool check = int.TryParse(tmp, out int number);
Console.WriteLine("");

if (check)
{
    PrintlistOfCubes (number);
}
else
{
    Console.WriteLine("Wrong Input");
}
