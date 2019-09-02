using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*C#에서 어떤 클래스를 사용하기 위해서는 일반적으로 먼저 클래스를 정의한 후 사용한다. 하지만 C# 3.0부터 클래스를 미리 정의하지 않고 
 * 사용할 수 있게 하는 익명타입(Anonymous Type)을 지원하게 되었다. Anonymous Type은 new { ... } 와 같은 형식을 사용하며, new 블럭안에 
 * 속성=값 할당을 하고, 각 속성/값은 콤마로 분리한다.

Anonymous Type은 읽기 전용이므로 속성값을 갱신할 수는 없다. C# 키워드 var는 컴파일러가 타입을 추론해서 찾아내도록 할 때 사용되는데, 
익명 타입 객체를 변수에 할당할 때는 특별히 타입명이 없으므로 var를 사용한다. 컴파일러는 익명 타입에 대해 내부적으로 임의의 클래스를 
생성하여 사용하게 된다. 

Anonymous Type은 공식적으로 클래스를 정의할 필요 없이 Type을 간단히 임시로 만들어 사용할 때 유용하다. 특히 Anonymous Type은 LINQ를 사용할 때 많이 사용된다.
아래 예제는 LINQ의 Where() 메서드를 이용해 특정 조건의 데이타를 찾은 후, Select() 메서드를 사용하여 일부 컬럼들로만 구성된 새 익명 타입을 만들어 리턴하는 예를 보여주고 있다
 */
namespace _13_AnonymousType1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 익명 타입 : new { 속성1=값, 속성2=값; }

            var t = new { Name = "홍길동", Age = 20 };
            string s = t.Name;
        }

        private void RunTest()
        {
            var v = new[] {
        new { Name="Lee", Age=33, Phone="02-111-1111" },
        new { Name="Kim", Age=25, Phone="02-222-2222" },
        new { Name="Park", Age=37, Phone="02-333-3333" },
    };

            // LINQ Select를 이용해 Name과 Age만 갖는 새 익명타입 객체들을 리턴.
            var list = v.Where(p => p.Age >= 30).Select(p => new { p.Name, p.Age });
            foreach (var a in list)
            {
                Debug.WriteLine(a.Name + a.Age);
            }
        }
    }
}
