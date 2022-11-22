using name;
int a = 0;
int b = int.Parse(args[0]);
int c = int.Parse(args[1]);

var d = new Computation(b);


if (c == 0)
{
    Console.WriteLine($"The sum of Odd are : {d.GetSumOf(a, b, d.isOdd)}");
}

if (c == 1)
{
    Console.WriteLine($"The sum of Odd are : {d.GetSumOf(a, b, d.isEven)}");
}
if (c == 2)
{
    Console.WriteLine($"The sum of Odd are : {d.GetSumOf(a, b, d.isPrime)}");
}
