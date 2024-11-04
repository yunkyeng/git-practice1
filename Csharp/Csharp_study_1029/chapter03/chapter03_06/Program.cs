using System;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        //배열(array)
        string productName1 = "데이크이지";
        string productName2 = "시티브리스우면";
        string productName3 = "필루미네드";
        string productName4 = "";

        int productPrice1 = 5000;
        int productPrice2 = 5500;
        int productPrice3 = 6000;
        int productPrice4 = 10000;

        //배열(array)
        int[] productPrices = new int[4]; // 필요한만큼만 배열을 선언해야 최적화를 할수 있다.★★
        string[] productNames = new string[4];

        productPrices[0] = 5000;
        productPrices[1] = 5500;
        productPrices[2] = 6000;
        productPrices[3] = 10000;
        //productPrices[4] = 10000;   //runtime 에러(실행중에 에러가 발생) : 배열크기초과

        //producetPrice; //빌드(build) 에러 : 타입미선언

        int i = 0;
        productPrices[i] = 5200;

        Console.WriteLine(productPrices[0]); //5200

        int book = productPrices[1] + productPrices[2];
        Console.WriteLine(book);

        //배열 선언 및 초기화
        int[] products = new int[5] { 1, 2, 3, 4, 5 };
        int[] products2 =  { 1, 2, 3, 4, 5 };

        Console.WriteLine(products[0]);
        Console.WriteLine(products[1]);
        Console.WriteLine(products2[0]);

        //문자열에 대한 배열
        string text = "Hello World";
        char ch1 = text[0]; //h
        char ch2 = text[1]; //e
        char ch11 = text[10]; //d
        //char ch12 = text[11]; //error -> text변수 answkduf 11개까지(0~10)만 저장이 되어 있음.

        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        Console.WriteLine(ch11);
        //Console.WriteLine(ch12);

        //배열의 기본값(int, float의 경우 0, string은 null)
        int[] students = new int[60];
        Console.WriteLine(students[0]); //출력 결과 : 0
        float[] sosu= new float[60];
        Console.WriteLine(sosu[0]); //출력 결과 : 0

        //다차원배열
        //2차원배열
        int[,] arr2 = new int[60,60]; // 60*60 int 공간을 가지 2차원 배열
        int[,,] arr3 = new int[60,60,60]; // 60*60*60 int 공간을 가지 3차원 배열

        int[,] arr4 = new int[7, 3]
            {
                {1,     2,  3},
                {4,     5,  6 },
                {7,     8,  9 },
                {10,    11, 12 },
                {4,     5,  6 },
                {4,     5,  6 },
                {4,     5,  6 }
            };
        Console.WriteLine(arr4[0,1]);
        Console.WriteLine(arr4[1, 0]);
        Console.WriteLine(arr4[2, 1]);

        //문제
        int[] arr6 = {1, 2, 3, 4, 5, 6};

        double result = (double)(arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6;
        Console.WriteLine(result);

        Console.WriteLine((arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6.0);

        Console.WriteLine((arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / (double)6);

        Console.WriteLine((arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / (double)arr6.Length);
    }

}