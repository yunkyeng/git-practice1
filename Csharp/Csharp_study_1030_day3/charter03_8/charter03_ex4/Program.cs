using System;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        // 문제 4: 모음 / 자음 판별
        // Q.사용자로부터 알파벳 문자를 입력받아 해당 문자가 모음(a, e, i, o, u)인지 자음인지 판별하는 프로그램을 작성
        // 대소문자 구분 없이 처리하고 Console.ReadKey()를 사용하세요.
        //   - 모음이면 '모음입니다' 출력
        //   - 자음이면 '자음입니다' 출력
        //   - 그 이외의 값은 '잘못된 입력입니다. 알파벳 문자를 입력하세요.' 출력

        Console.WriteLine("알파벳 문자를 입력하세요: ");
        ConsoleKeyInfo charKey = Console.ReadKey();
        Console.WriteLine();  // 줄바꿈

        char letter = charKey.KeyChar;
        // 코드 작성
        /*
        if (   letter == 'a' || letter == 'e' || letter == 'i'
            || letter == 'o' || letter == 'u'
            || letter == 'A' || letter == 'E' || letter == 'I'
            || letter == 'O' || letter == 'U') Console.WriteLine("모음입니다");
        else Console.WriteLine("자음입니다.");
        */

        /* (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z') --> char.IsLetter(letter) 변경가능*/
        switch (charKey.KeyChar)
        {
            case 'a':           case 'e':             case 'i':           case 'o':            case 'u': //모음소문자
            case 'A':           case 'E':             case 'I':           case 'O':            case 'U': //모음대문자
                Console.WriteLine("모음입니다");
                break;
            default:
                if (char.IsLetter(letter)) Console.WriteLine("자음입니다.");
                else Console.WriteLine("잘못된 입력입니다. 알파벳 문자를 입력하세요.");
                break;
        }



























                /*
        switch (charKey.KeyChar)
        {
            case 'a':           case 'e':             case 'i':           case 'o':            case 'u': //모음소문자
            case 'A':           case 'E':             case 'I':           case 'O':            case 'U': //모음대문자
                Console.WriteLine("모음입니다");
                break;

            //case 'b':            case 'c':            case 'd':            case 'f':            case 'g':
            //case 'h':            case 'j':            case 'k':            case 'l':            case 'm':
            //case 'n':            case 'p':            case 'q':            case 'r':            case 's':
            //case 't':            case 'v':            case 'w':            case 'x':            case 'y':
            //case 'z': //자음소문자
            //case 'B':            case 'C':            case 'D':            case 'F':            case 'G':
            //case 'H':            case 'J':            case 'K':            case 'L':            case 'M':
            //case 'N':            case 'P':            case 'Q':            case 'R':            case 'S':
            //case 'T':            case 'V':            case 'W':            case 'X':            case 'Y':
            //case 'Z': //자음대문자
            //    Console.WriteLine("자음입니다");
            //    break;

            default: 
                Console.WriteLine("자음입니다.");
                break;
        }
        */
        }

}