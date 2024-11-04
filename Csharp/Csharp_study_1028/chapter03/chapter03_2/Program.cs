//실수형기본타입
// 1)fload -> 4byte(2의32승)
// 2)double -> 8byte(2의64승)

namespace ConsoleApp1;

class Program
{
 static void Main(string[] args)
    {
        //float f = 5.2f;
        //double d = 10.5;
        //decimal money = 200.099m;

        //Console.WriteLine(f);
        //Console.WriteLine(d);
        //Console.WriteLine(money);

        //문제1. 
        int age = 25;
        Console.WriteLine(age);

        double height = 175;
        Console.WriteLine(height);

        //문제2. 
        int num = 300;
        double result = 175;
        result = num + 100.5;

        Console.WriteLine(result);
    }
}