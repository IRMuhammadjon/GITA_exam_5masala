Console.WriteLine("Sonni kiriting: ");
var a = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i < a; i++)
{
    int b = 0;
    for (int f = 1; f < i; f++)
    {
        if (i % f == 0)
        {
            b = b + f;
        }
    }
    if (i == b)
    {
        Console.WriteLine(b + "   ");
    }
}