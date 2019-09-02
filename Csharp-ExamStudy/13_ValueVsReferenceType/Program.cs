using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C#은 Value Type과 Reference Type을 지원한다. C#에서는 struct를 사용하면 Value Type을 만들고, class 를 사용하면 Reference Type을 만든다.
 * C# .NET의 기본 데이타형들은 struct로 정의되어 있다
 * Value Type의 파라미터 전달은 데이타를 복사(copy)하여 전달하는 반면, Reference Type은 Heap 상의 객체에 대한 레퍼런스(reference)를 전달하여 이루어진다
 */
namespace _13_ValueVsReferenceType
{
    class Program
    {
        // 구조체 정의
        struct MyPoint
        {
            public int X;
            public int Y;

            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }
        }
        static void Main(string[] args)
        {
            // 구조체 사용
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }
}
