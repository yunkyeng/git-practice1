﻿namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        // 문제1: AND, OR 혼합 조건
        // Q.다음 조건을 모두 만족할 경우 "모든 조건 충족"을 출력하시오. 아닐 경우는 "조건 불충족"
        //   age는 18 이상 60 이하
        //   isHealthy가 true이고 hasInsurance가 true
        int age = 35;
        bool isHealthy = false;
        bool isAlive   = true;
        if ((age >= 18) && (age <= 60) && (isHealthy && isAlive))  Console.WriteLine("1번답:"+"모든조건충족"); 
        else Console.WriteLine("1번답:" + "조건 불충족");

        // 문제2: 논리 연산자를 사용한 비밀번호 확인
        // Q.사용자가 입력한 password와 confirmPassword가 모두 일치하고,
        // 길이가 8 이상일 때 "비밀번호 설정 완료"를 출력하시오.
        //  cf) 길이는 Length값 이용.   ex) password.Length
        String password = "secure123";
        string confirmPassword = "secure123";

        if ((password.Length >= 8)&&(password == confirmPassword)) Console.WriteLine("2번답:" + "비밀번호 설정 완료");
        else Console.WriteLine("2번답:" + "비밀번호 설정 실패");

        // 문제3: Null 체크와 단축 평가
        // Q.변수 userName이 null이 아니고, 길이가 5 이상일 경우 "유효한 사용자 이름"을 출력하시오. 단, userName이 null일 때는.Length를 호출하지 않도록 주의하세요.
        String userName = null;
        if ((userName != null)&& (userName.Length >= 5)) Console.WriteLine("3번답:" + "유효한 사용자 이름");
        else Console.WriteLine("3번답:" + "유효하지 않은 사용자 이름");

        // 문제4: 배열 길이와 단축 평가
        // Q. 배열 numbers가 null이 아니고, 길이가 3 이상일 경우 배열의 세 번째 요소를 출력하시오.
        int[] numbers = { 1, 2, 3, 4, 5 };
        if ((numbers != null) && (numbers.Length >= 3)) Console.WriteLine("4번답:" + numbers[2]);
        else Console.WriteLine("3번답:" + "해당없음");

    }

}