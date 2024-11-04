using System;
using System.ComponentModel.Design;
using System.Reflection;

namespace ConsoleApp1;

class Program
{
    // 문제: 로또 프로그램 만들기
    // 로또 프로그램의 조건
    //   (1) 1 ~ 45까지 랜덤한 숫자 6자리를 출력
    //   (2) 숫자 6개는 같은 숫자가 나올 수 없다.

    // 예시
    //   생성된 로또 번호: 5 6 7 19 44 1
    //   프로그램 종료
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] lottoNumbers = new int[6];
        int i = 0;
        int j = 0;
        int newNumber_;

        // 코드작성(while문과 if문 break를 활용하여 작성)

        
        while (i < 6)
        {
            newNumber_ = random.Next(1, 46);  //(1) 1 ~ 45까지 랜덤한 숫자

            while (j < 6)
            {
                if (i == 0 && j < 1)
                {
                    lottoNumbers[i] = newNumber_;
                    Console.WriteLine("로또번호1 : " + lottoNumbers[i]);
                }
                else
                {
                    if (lottoNumbers[i] != lottoNumbers[j])
                    {
                        lottoNumbers[i] = newNumber_;
                        Console.WriteLine("로또번호 : " + lottoNumbers[i]);
                    }
                }
                j++;
            }
            i++;
        }

        Console.WriteLine("생성된 로또 번호 : ");
        int printIndex = 0;
        while (printIndex < lottoNumbers.Length)
        {
            Console.Write(lottoNumbers[printIndex] + " ");
            printIndex++;
        }


        /* 
        //쌤코드
        int index = 0;  
        while (index < lottoNumbers.Length)
        {
            int newNumber = random.Next(1, 46);

            bool isDuplicate = false;
            // 중복된 값이 있는지 체크하는 코드
            int checkIndex = 0;
            while (checkIndex < index)
            {
                if (lottoNumbers[checkIndex] == newNumber)
                {
                    isDuplicate = true;
                    break;
                }
                checkIndex++;
            }

            if (!isDuplicate)    // 중복된 값이 없으면 로또번호로 저장
            {
                lottoNumbers[index] = newNumber;
                index++;
            }
        }

        Console.WriteLine("생성된 로또 번호");
        int printIndex = 0;
        while (printIndex < lottoNumbers.Length)
        {
            Console.Write(lottoNumbers[printIndex] + " ");
            printIndex++;
        }

        */
    }
}