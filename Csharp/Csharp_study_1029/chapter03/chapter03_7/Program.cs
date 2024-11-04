namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        //제어문(Control statement)
        //0. 관계 및 논리연산자
        //  -관계연산자:>(크다), >=(크거나 같다), <=(작거나같다), <작다, ==(같다), !=(다르다)
        //  -논리연산자:&&, ||, !
        bool result = 10 > 20;
        Console.WriteLine(result); // false

        bool result2 = 10 < 20;
        Console.WriteLine(result2); //true

        int value1 = 6;
        int n1 = value1 % 3;
        bool result3 = (n1 == 0);
        Console.WriteLine(result3); //true

        //  -논리연산자:&&(AND), ||(OR), !(NOT)
        // ex) A AND B : AND연산자는 A와 B의 논리값이 하나라도 false이면 결과는 false
        // ex) A OR(||) B : OR연산자는 A와 B의 놀리값이 하나라도 true이면 결과는 true
        int value2 = 10;
        int n3 = value2 % 3;
        int n4 = value2 % 5;

        bool orResult1 = (n3 == 0 || n4 == 0);
        Console.WriteLine("value는 3의 배수이거나 5의 배수이면 : "+orResult1);

        bool andResult1 = (n3 == 0 && n4 == 0);
        Console.WriteLine("value는 3의 배수이고 5의 배수이면 : " + andResult1);

        bool notResult1 = !(n3 == 0);
        Console.WriteLine("value는 3의 배수가 아님 : " + notResult1);


        //1. 선택문(if, switch)

    }

}