using System;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); //사용자의 키보드 입력을 받은 문자처리
        Console.WriteLine(); //줄바꿈
        //입력받은 문자 출력
        Console.WriteLine(keyInfo.KeyChar);  

        // 제어문
        // switch
        /*
         * switch(인스턴스) 인스턴스 : 변수이름
         * {
         *      case    상수식1:
         *              구문1;
         *              break;
         *      case    상수식1:
         *              구문1;
         *              break;
         *              .
         *              .
         *              .
         *      default:  //생략가능
         *              구문n;
         *              break;
         * }
         * 
         */

        char ch = 'F'; //Female
        switch (ch)
        {
            case 'M':
                Console.WriteLine("남성");
                break;

            case 'F':
                Console.WriteLine("여성");
                break;

            default: //생략도가능하다.
                Console.WriteLine("알수없음");
                break;
        }

        if (ch == 'M')      Console.WriteLine("남성");
        else if (ch == 'F') Console.WriteLine("여성");
        else                Console.WriteLine("알 수 없음");

        //-------------------------------------------------------------------------------------
        String text = "C#";
        switch (text)
        {
            case "C#":
            case "VB.NET":
                Console.WriteLine(".NET 호환 언어");
                break;

            case "JAVA":
                Console.WriteLine("JVM 언어");
                break;

            default: //생략도가능하다.
                Console.WriteLine("알수없음");
                break;
        }

        if (text == "C#" || text == "VB.NET") Console.WriteLine(".NET 호환 언어");
        else if (text == "JAVA") Console.WriteLine("JVM 언어");
        else Console.WriteLine("알수없음");

    }
}