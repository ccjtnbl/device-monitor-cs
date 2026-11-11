Console.Write("第一个数: ");
 double a =  double .Parse(Console.ReadLine());
Console.Write("第二个数：");
 double b =  double .Parse(Console.ReadLine());

Console.WriteLine($"和：{a + b}");
Console.WriteLine($"差：{a - b}");
Console.WriteLine($"积：{a * b}");

if (b == 0)
{
    Console.WriteLine(" 除数不为0，跳过");
}
else
{
    Console.WriteLine($"除: {a / b}");
    Console.WriteLine($"余: {a % b}");
}
Console.ReadKey();
while (true)
{
    Console.Write("继续?(q 退出)");
    if(Console.ReadLine() == "q")
    {
        break;
    }
}
