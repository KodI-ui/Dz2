using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Boolean1();
            Boolean2();
            Boolean10();
            Boolean11();
            Boolean14();*/
            Boolean23();

        }

        //Boolean1◦Дано целое число A.Проверить истинность высказывания: «Число A является положительным».
        static void Boolean1()
        {
            int A = int.Parse(Console.ReadLine());
            bool B = A > 0;
            Console.WriteLine(B);
        }
        static void Boolean2()
        {
            int A = int.Parse(Console.ReadLine());
            bool B = A % 2 != 0;
            Console.WriteLine(B);
        }
        static void Boolean3()
        {
            int A = int.Parse(Console.ReadLine());
            bool B = A % 2 == 0;
            Console.WriteLine(B);
        }
        static void Boolean4()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            bool C = A > 2 && B <= 3;
            Console.WriteLine(C);
        }
        static void Boolean5()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            bool C = A >= 0 || B < -2;
            Console.WriteLine(C);
        }
        static void Boolean6()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool D = A < B && B < C;
            Console.WriteLine(D);
        }
        static void Boolean7()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool D = A < B && B < C;
            Console.WriteLine(D);
        }
        static void Boolean8()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            bool C = A % 2 != 0 && B % 2 != 0;
            Console.WriteLine(C);

        }
        static void Boolean9()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            bool C = A % 2 != 0 || B % 2 != 0;
            Console.WriteLine(C);
        }
        static void Boolean10()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            bool C = A % 2 != 0 ^ B % 2 != 0;
            Console.WriteLine(C);
        }
        static void Boolean11()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            bool C = A % 2 == B % 2;
            Console.WriteLine(C);
        }
        static void Boolean12()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool D = A > 0 && B > 0 && C > 0;
            Console.WriteLine(D);
        }
        static void Boolean13()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool D = A > 0 || B > 0 || C > 0;
            Console.WriteLine(D);
        }
        static void Boolean14()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool V = A > 0 && B < 0 && C < 0;
            bool N = A < 0 && B < 0 && C > 0;
            bool L = A < 0 && B > 0 && C < 0;
            bool D = V || N || L;
            Console.WriteLine(D);
        }
        static void Boolean15()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool V = A > 0 && B > 0 && C < 0;
            bool N = A < 0 && B > 0 && C > 0;
            bool L = A > 0 && B < 0 && C > 0;
            bool D = V || N || L;
            Console.WriteLine(D);
        }
        static void Boolean16()
        {
            int A = int.Parse(Console.ReadLine());
            bool B = A / 10 > 0 && A % 2 == 0;
            Console.WriteLine(B);
        }
        static void Boolean17()
        {
            int A = int.Parse(Console.ReadLine());
            bool B = A / 100 > 0 && A % 2 != 0;
            Console.WriteLine(B);
        }
        static void Boolean18()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool V = A == B || A == C || B == C;
            Console.WriteLine(V);
        }
        static void Boolean20()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool V = A != B && A != C && B != C;
            Console.WriteLine(V);
        }
        static void Boolean21()
        {
            int abc = int.Parse(Console.ReadLine());
            int a = abc / 100;
            int b = abc / 10 % 10;
            int c = abc % 100 % 10;
            bool V = a > b && b > c;
        }
        static void Boolean22()
        {
            int abc = int.Parse(Console.ReadLine());
            int a = abc / 100;
            int b = abc / 10 % 10;
            int c = abc % 100 % 10;
            bool V = (a > b && b > c) || (a < b && b < c);
        }
        static void Boolean23()
        {
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = abcd / 100 % 10;
            int c = abcd % 1000 % 100 / 10;
            int d = abcd % 1000 % 100 % 10;
            bool V = a == d && b == c;
            Console.WriteLine(V);
        }
        static void Boolean24()
        {

        }
    }
}
