namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //string text1 = "안녕하세요";

        //// for문으로 분할해서 출력 (string 배열을 이용)
        //for (int i = 0; i < text1.Length; i++)
        //{
        //    Console.Write(text1[i]);
        //}


        // 문제
        // 힌트: 감소연산자(--) -> ex) for (int i = 9; i >= 0; i--)
        Console.WriteLine("문자열을 입력하세요");
        String input = Console.ReadLine();
        string reverse = "";

        
        for (int i = input.Length-1; i >= 0; i--)
        {
            reverse += input[i];
        }
        Console.WriteLine(reverse);
    }
}