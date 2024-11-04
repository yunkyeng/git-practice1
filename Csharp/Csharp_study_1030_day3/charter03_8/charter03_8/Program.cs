namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        //제어문
        //  (1) if문 문법
        /*  여러줄 주석
         *  if(조건문(rhksrPdustkswk ghrdms shffldustksrk))
         *  구문; 
         *  
         *  ->조건문이 true이면 '구문'을 실행 false이면 구문을 실행하기 않음
         *  
         *  if (조건문(관계연산자 혹은 놀리연산자) 구문;     
         *  
         *  if문에 중괄호({})가 없는 경우 구문을 1줄만(only) 실행가능         
         *  if문에 중괄호({})가 없는 경우 구문을 2개이상 무조건 사용해야한다.
         *      cf) 구문의 단위는 ';'로 구분
         */

        //프로그램 내용 3의 배수일 결우에 '3의 배수' 출력이 되는 프로그램 생성
        int a = 5;
        int b = 8;

        if (a % 3 == 0) 
            Console.WriteLine("a는 3의 배수1");

        //if (b % 3 == 0)
        //    Console.WriteLine("b는 3의 배수2");

        if ((b % 3 == 0) && (b % 2 == 0))
        {
            Console.WriteLine("b는 2의 배수3");
            Console.WriteLine("b는 3의 배수4");
        }

        if (6 % 3 == 0)
        {
            Console.WriteLine("6은 3의 배수5");
            Console.WriteLine("연산 결과 끝!");
        }

        // value변수의 값과  if문으로 짝수 홀수 구분해서 출력하기
        int value = 5;
        if (value % 2 == 0)
        {
            Console.WriteLine("value는 2의 배수");
            Console.WriteLine("따라서 짝수");
        }
        else    //false일 경우 실행
        {
            Console.WriteLine("value는 홀수");
        }

        //else if사용하기
        if (value <= 255)           Console.WriteLine("byte로 변환이 가능");
        else if (value <= 65535)    Console.WriteLine("ushort로 변환이 가능");
        else if (value <= 210000000) Console.WriteLine("int타입으로 변환이 가능");
        else                        Console.WriteLine("int 타입");


        //삼항 연산자
        //문법 : (조건식) ? 표현식1 : 표현식2
        //설명 : 조건식이 true이면 '표현식1'을 실행하고 false이면 '표현식2'을 실행

        int value2 = 5;
        string result;

        if (value2 % 2 == 0)
        {
            result = "짝수";
        }
        else
        {
            result = "홀수";
        }
        Console.WriteLine(result); //홀수

        // 위의 코드를 삼항연산자로 변환
        String result2 = (value2 % 2 == 0) ? "짝수" : "홀수";
        Console.WriteLine(result2); //홀수

        //문제 1. 변수가 age가 20이상이고 hasLicense가 true일 경우 '운전가능'을 출력하고 false일 경우 '운전 불가'라고 출력
        int age = 30;
        bool hasLicense = true;

        //일산연산
        if ((age >= 20) && (hasLicense = true)) Console.WriteLine("운전가능"); else Console.WriteLine("운전불가");

        //삼항연산
        String result3 = ((age >= 20) && (hasLicense = true)) ? "운전가능" : "운전불가";
        Console.WriteLine(result3);

        //삼항연산
        String result4 = ((age >= 20) && (hasLicense)) ? "운전가능" : "운전불가";
        Console.WriteLine(result4);

        //문제 2. 아래의 변수 isWeekend와 isHoliday 중 하나라도 true일 경우 '쉬는 날입니다' 출력
        //false일 경우 '일하는 날입니다' 출력
        bool isWeekend = false;
        bool isHoliday = true;

        //일반
        if(isWeekend || isHoliday) Console.WriteLine("쉬는 날입니다");
        else Console.WriteLine("일하는날입니다");

        //삼항연산
        int value3 = 5; //날짜
        String result5 = (value3 == 0) ? "일하는날입니다" : "쉬는날입니다";
        Console.WriteLine(result5);


    }
}