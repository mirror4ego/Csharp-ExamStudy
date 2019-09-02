using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_MethodParam
{
    class Program
    {
        static double GetData(ref int a, ref double b)
        { return ++a * ++b; }

        // out 정의
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        // Optional 파라미터: calcType
        int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        private void Calculate(int a)
        {
            a *= 2;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //Pass by Value
            int val = 100;
            p.Calculate(val);
            // val는 그대로 100    
            Console.WriteLine(val);

            //Pass by Reference
            // ref 사용. 초기화 필요.
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);

            // out 사용. 초기화 불필요.
            int c, d;
            bool bret = GetData(10, 20, out c, out d);

            // Named Parameter
            Method1(name: "John", age: 10, score: 90);

            //Optional Parameter : 디폴트 값이 있을 경우 생략가능
            Program p = new Program();
            int ret = p.Calc(1, 2);
            ret = p.Calc(1, 2, "*");

            // Params : 파라미터 개수를 미리 알 수 없는 경우
            //메서드
            int Calc(params int[] values);

            //사용
            int s = Calc(1, 2, 3, 4);
            s = Calc(6, 7, 8, 9, 10, 11);

        }
    }
}
