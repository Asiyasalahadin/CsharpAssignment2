// See https://aka.ms/new-console-template for more information
int num;
//ASSignment
do
{
    Console.WriteLine("Enter a number");
    num = Convert.ToInt32(Console.ReadLine());

    if (num == 0)
        Console.WriteLine("Neither odd nor even");
    else if (num % 2 == 0)
        Console.WriteLine("Number is Even");

    else
    {
        Console.WriteLine("Number is Odd");
    }

} while (
