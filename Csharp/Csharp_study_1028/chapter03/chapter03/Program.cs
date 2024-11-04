//3.1 기본 자료형
//3.1.1 정수형 기본 타입 (<-> 소수, 실수, 허수)

using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1;

class Program
{

    static void Main(string[] args) 
    {
        //자료형 변수명
        int n ; // 32bit 정수형의 n이라는 변수명을 선언
        long sum;

        int a = 100000000;
        long b = 100;

        int n1 = 50;
        int n2;
        n2 = 100;

        sum = n1 + n2;
        sum = 14;
        Console.WriteLine(sum); //춮력결과

        System.Int32 c1 = 10;
        System.Int32 c2;
        c2 = 100;
        System.Int32 sum2 = c1 + c2;
        Console.WriteLine(sum2);
    }
}