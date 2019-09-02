using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ExtensionMethod
{
    public static class ExClass
    {
        // static 확장메서드를 정의. 첫번째 파라미터는
        // 어떤 클래스가 사용할 지만 지정. 
        public static string ToChangeCase(this String str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                    sb.Append((char)('a' + ch - 'A'));
                else if (ch >= 'a' && ch <= 'x')
                    sb.Append((char)('A' + ch - 'a'));
                else
                    sb.Append(ch);
            }
            return sb.ToString();
        }

        // 이 확장메서드는 파라미터 ch가 필요함
        public static bool Found(this String str, char ch)
        {
            int position = str.IndexOf(ch);
            return position >= 0;
        }
    }
    class Program
    {
        // static class를 정의


        static void Main(string[] args)
        {
            string s = "This is a Test";

            // s객체 즉 String객체가
            // 확장메서드의 첫 파리미터임
            // 실제 ToChangeCase() 메서드는
            // 파라미터를 갖지 않는다.
            string s2 = s.ToChangeCase();

            // String 객체가 사용하는 확장메서드이며
            // z 값을 파라미터로 사용
            bool found = s.Found('z');
        }
    }
}
