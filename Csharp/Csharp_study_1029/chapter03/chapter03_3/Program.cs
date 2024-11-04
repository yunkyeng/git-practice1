//문자형 기본타입
// 1. char : 유니코드 16bit 문자. (cf) 8it(256개) ASCII코드 범위 U+0000~U+FFF(16진수)
//2. Sring : char의 조합 문자열 ex)school

// boolean 기본타입
//1. bool: true, false

using System;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        char ch = 'A';
        string str1 = "A";
        string str2 = "school";

        Console.WriteLine(ch);
        Console.WriteLine(str1); 
        Console.WriteLine(str2);

        char ch1 = '\t'; //tab문자 표현
        char ch2 = 'T'; //test문자
        char ch3 = '\n'; //개행(new line)(한줄띄우기) 문자를 표현
        char ch4 = 'o'; //test문자

        Console.Write(ch1);
        Console.Write(ch2);
        Console.Write(ch3);
        Console.Write(ch4);


        Console.WriteLine(ch1);

        char ch5 = '\u0088';

        Console.WriteLine(ch5);

        string spl = "▶";
        Console.WriteLine(spl);

        char ch6 = '\\';
        Console.WriteLine(ch6);

        string str3 = "\\10,000";
        Console.WriteLine(str3);

        string str4 = "Hello, World"; //Hello, World
        Console.WriteLine(str4);

        string str5 = "\"Hello, World\""; //"Hello, World"
        Console.WriteLine(str5);

        string str6 = "\tHello\tWorld";
        Console.WriteLine(str6);

        string str7 = @"\tHellow\tWorld"; //\tHellow\tWorld
        Console.WriteLine(str7);

        string str8 = "Hello";
        Console.WriteLine(str8 + "" + "World!");    //HelloWorld!

        //정수형(8가지 - int), 실수형(3가지 - double), 문자열(2가지 - string), 불린형(1가지 - bool)
        bool bl1 = true;
        Console.WriteLine("bl1의 값은" + bl1);

        /*
        string a = "10000";
        string b = "10000";
        string c = a + b; //1000010000

        string a1 = 10000;
        string b2 = 10000;
        string c1 = a + b;//20000
        */
    }
}