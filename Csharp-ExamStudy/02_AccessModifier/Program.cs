using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*접근 제한자는 외부로부터 타입(클래스, 구조체, 인터페이스, 델리게이트 등) 혹은 그 타입 멤버들(메서드, 속성, 이벤트, 필드 등)로의 접근을 제한할 때 사용하는 것으로 다음과 같은 종류가 있다.
 * 접근 제한자는 public class A {} 와 같이 클래스, 구조체와 같은 Type 앞에 사용하거나 메서드, 속성, 필드 등의 클래스/구조체 멤버 앞에 사용하여 (예: protected int GetValue(); ) 접근을 제한하게 된다.
 * 클래스 멤버는 5가지의 접근 제한자를 (public, internal, private, protected, protected internal) 모두 가질 수 있지만, 
 * 구조체(struct) 멤버는 상속이 되지 않으므로 3가지의 접근 제한자만 (public, internal, private) 가질 수 있다.
보틍 클래스와 구조체는 네임스페이스 바로 밑에 선언하는데,이때 디폴트로 internal 접근 제한을 갖는다.
단, 클래스 내부에 Nested 클래스를 선언하는 것과 같이 Nested Type을 선언하면 디폴트로 private 접근 제한을 갖는다.
인터페이스(interface)와 열거형(enum)의 멤버는 기본적으로 public 이며, 각 멤버에 별도의 접근 제한자를 사용하지 않는다.
*/
namespace _02_AccessModifier
{
    //클래스의 필드는 기본적으로 private으로 설정하여 외부로터의 접근을 완전히 제한하는 것이 일반적이다 (객체 지향 프로그래밍의 원칙에 따라). 
    //메서드는 외부에서 호출해야 하는 것은 public으로 하고 내부에서만 사용되는 것은 private으로 설정한다.
    internal class MyClass
    {
        private int _id = 0;

        public string Name { get; set; }

        public void Run(int id) { }

        protected void Execute() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
