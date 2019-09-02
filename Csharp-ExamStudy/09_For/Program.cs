using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_For
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 루프
            for (int i5 = 0; i5 < 10; i5++)
            {
                Console.WriteLine("Loop {0}", i5);
            }

            // for vs foreach
            // 3차배열 선언
            string[,,] arr = new string[,,] {
            { {"1", "2"}, {"11","22"} },
            { {"3", "4"}, {"33", "44"} }
    };

            //for 루프 : 3번 루프를 만들어 돌림
            for (int i3 = 0; i3 < arr.GetLength(0); i3++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Debug.WriteLine(arr[i3, j, k]);
                    }
                }
            }

            //foreach 루프 : 한번에 3차배열 모두 처리
            foreach (var s in arr)
            {
                Debug.WriteLine(s);
            }

            // while 반복 구문
            int i = 1;

            // while 루프
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // do while 반복 구문
            int i4 = 1;

            // do ~ while 루프
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            // 반복 구문 예제
            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                keyList.Add(key.KeyChar);
            } while (key.Key != ConsoleKey.Q); // Q가 아니면 계속

            Console.WriteLine();
            foreach (char ch in keyList) // 리스트 루프
            {
                Console.Write(ch);
            }
        }
    }
}
