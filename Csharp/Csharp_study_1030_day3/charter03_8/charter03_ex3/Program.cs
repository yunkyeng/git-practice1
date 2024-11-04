﻿namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        //ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 키보드 입력을 받은 문자를 처리(문자1개만받을수 있음)

        // Console.ReadLine 사용예제
        /*
        string input1 = Console.ReadLine();// 문자가 1개이상을 입력받을수 있또록 대기
        Console.WriteLine("입력한 값 : " + input1);

        int number = int.Parse(input1); //input1 문자열을 숫자로 변형
        Console.WriteLine("입력한 값 :" + number );
        */

        // 문제: 계산기 기능 구현
        // 사용자로부터 두 숫자와 연산자(+, -, *, /)를 입력받아 계산 결과를 출력하는 switch문을 작성하세요.
        //   1. 먼저 두 숫자를 입력받은 후,
        //   2. 연산자는 Console.ReadKey()로 입력받아 처리합니다.

        // 예시 입력: 
        // 첫 번째 숫자: 10
        // 두 번째 숫자: 5
        // 연산자를 입력하세요 (+, -, *, /): +
        // 출력: 결과: 15
        Console.Write("첫 번째 숫자를 입력하세요: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("두 번째 숫자를 입력하세요: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("연산자를 입력하세요 (+, -, *, /): ");
        ConsoleKeyInfo operationKey = Console.ReadKey();
        Console.WriteLine();  // 줄바꿈

        switch(operationKey.KeyChar)
        {
            case '+': Console.WriteLine((num1 + num2).ToString()); break;
            case '-': Console.WriteLine((num1 - num2).ToString()); break;
            case '*': Console.WriteLine((num1 * num2).ToString()); break;
            case '/':
                if (num2 == 0) {Console.WriteLine("0으로 나눌 수는 없습니다"); }
                else           {Console.WriteLine((num1 / num2).ToString()); }break;
            default : Console.WriteLine("잘못된 선택입니다"); break;
        }
    }

}