namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); //사용자의 키보드 입력을 받은 문자처리
        Console.WriteLine(); //줄바꿈

        //입력받은 문자 출력
        Console.WriteLine("입력한 값 : " + keyInfo.KeyChar); //사용자 키보드 입력한 것 출력

        switch (keyInfo.KeyChar)
        {
            case 'M':
            case 'm':
            case '남':
                Console.WriteLine("남성");
                break;

            case 'F':
                Console.WriteLine("여성");
                break;

            default: //생략도가능하다.
                Console.WriteLine("알수없음");
                break;
        }

    }

}