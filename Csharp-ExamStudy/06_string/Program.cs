using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*#의 키워드 string은 .NET의 System.String 클래스와 동일하며, 따라서 System.String 클래스의 모든 메서드와 속성(Property)을 사용가능
 * C# 문자열은 Immutable 즉 한번 문자열이 설정되면, 다시 변경할 수 없다. (주: 한번 그 값이 설정되면 다시 변경할 수 없는 타입을 Immutable Type이라 부르고, 
 * 반대로 값을 계속 변경할 수 있는 것을 Mutable Type이라 부른다) 예를 들어, 문자열 변수 s 가 있을 때, s = "C#"; 이라고 한 후 다시 s = "F#"; 이라고 실행하면, 
 * .NET 시스템은 새로운 string 객체를 생성하여 "F#"이라는 데이타로 초기화 한 후 이를 변수명 s 에 할당한다. 즉, 변수 s 는 내부적으로는 전혀 다른 메모리를 갖는 객체를 가리키는 것
 */
namespace _06_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열(string) 변수
            string s1 = "C#";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1.GetHashCode());
            s1 = "F#"; // 해쉬값이 변경됨
            Console.WriteLine(s1.GetHashCode());
            string s2 = "Programming";

            // 문자(char) 변수 
            char c1 = 'A';
            char c2 = 'B';

            // 문자열 결합
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            // 부분문자열 발췌
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);

            string s = "C# Studies";

            // 문자열을 배열인덱스로 한문자 엑세스 
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, s[i]);
            }

            // C# 문자열, 문자, 문자배열 


            // 문자열을 문자배열로 변환
            //문자열(string)은 문자(character)의 집합체이다. 문자열 안에 있는 각 문자를 엑세스하고 싶으면, [인덱스] (square bracket)을 사용하여 문자 요소를 엑세스한다
            string str = "Hello";
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            // 문자배열을 문자열로 변환
            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(charArray2);

            Console.WriteLine(s);

            // 문자 연산
            //하나의 문자는 상응하는 ASCII 코드 값을 가지는데, 예를 들어 대문자 A는 65, B는 66, Z는 90을 갖는다. 소문자는 a가 97, b가 98, ... 등을 갖는다
            char c4 = 'A';
            char c5 = (char)(c4 + 3);
            Console.WriteLine(c5);  // D 출력
        }
    }
}
