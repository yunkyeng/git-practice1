using System.Diagnostics.Tracing;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        //예약어(preserved), 키워드(EventKeywords) : c#에서 미리 사용하고 있는 단어(변수명으로 사용X)
        int voidstring = 1;

        //식별자

        //null 키워드 사용하기

        string? text = null; // 데이터 타입 제일 오른쪾에 '?'표시를 넣으면 null사용★★★
        int? a1 = 1;
        a1 = null;

        //string text1 = "";

        //데이터타이브이 기본값
        bool result; //이렇게 사용할수 없음

        //Console.WriteLine("result:" + result);

        //상수(★변하지 않는 수 - const키워드) : const가 붙은 변수명인 경우 값을 수정하면 error가남★★★
        const bool result2 = false;
        //result2 = true;

        const int n1 = 10 + 10;
        int n = Math.Max(0, 5); //Max값 찾는 함수 사용. Min도 사용할수 있음. 

        //연산자(+,-,*,/,%)
        // %는 나누었을때의 나머지만 구할수 있음. 
        int z1 = 3 % 2;
        Console.WriteLine(" 3 % 2 의 나머지는" + z1);

        int z2 = 4 % 2;
        Console.WriteLine(" 4 % 2 의 나머지는" + z2);

        int x1 = 3 / 2;
        Console.WriteLine(" 3나누기 2의 값은?" + x1);


        double x2 = 3 / 2.0;  //★★정수/정수->정수, 실수/정수->상수★★
        Console.WriteLine(" 3나누기 2의 값은?" + x2);

        double x3 = 3 / (double)2;  //★★정수/정수->정수, 실수/정수->상수★★
        Console.WriteLine(" 3나누기 2의 값은?" + x3);

        //double result1 = 4.0;
        //Console.WriteLine(result1);
    }

}