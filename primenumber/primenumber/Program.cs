Console.WriteLine("Enter the first num");
int first_num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second num");
int second_num = int.Parse(Console.ReadLine());

for (int i = first_num; i < second_num; i++)
{
    bool isprime = true;
    for (int j = 2; j <= i / 2; j++)
    {
        if ((i % j) == 0)
        {
            isprime = false;
            break;
        }
    }
    if (isprime && i !=0 && i != 1)
        Console.WriteLine(i);
}