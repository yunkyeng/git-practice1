using System;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        ////while 무한루프
        //while (true) 
        //{ 
        //    Console.WriteLine("무한루프입니다");

        //    break; //while문을 빠져나가는 코드
        //}

        // 문제: 사용자가 종료를 원할 때까지 반복
        //   Q: 사용자로부터 숫자를 계속 입력받고, 그 숫자를 출력합니다.
        //      사용자가 "exit"를 입력할 때까지 반복합니다.
        // 예시
        // 숫자를 입력하세요. (종료하려면 'exit' 입력): 12
        // 입력한 숫자: 12
        // 숫자를 입력하세요. (종료하려면 'exit' 입력): 34
        // 입력한 숫자: 34
        // 숫자를 입력하세요. (종료하려면 'exit' 입력): 123
        // 입력한 숫자: 123
        // 숫자를 입력하세요. (종료하려면 'exit' 입력): exit
        // 프로그램을 종료합니다.

        string input;
        string keyExit = "exit";

        while (true)
        {
            Console.WriteLine("숫자를 입력하세요");
            input = Console.ReadLine();

            if (input == keyExit)
            {
                Console.WriteLine("프로그램을 종료합니다.");
                break; 
            }
            Console.WriteLine("입력한 숫자 : " + input);
        }
    }

}