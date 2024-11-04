using System;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {

        int i = 0;

        for (i = 1; i<=50; i++) 
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{i}는 FizzBuzz"); // 3과 5의 배수
            }else if (i % 3 == 0)  // 3의 배수
            {
                Console.WriteLine($"{i}는 Fizz");
            }
            else if (i % 5 == 0)  // 5의 배수
            {
                Console.WriteLine($"{i}는 Buzz");
            }
            else
            { 
                Console.WriteLine(i); // 나머지
            }
        }
    }

}