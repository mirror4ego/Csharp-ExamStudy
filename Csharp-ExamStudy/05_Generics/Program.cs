using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 제네릭 타입에서는 int, float, double 같은 데이타 요소 타입을 확정하지 않고 이 데이타 타입 자체를 타입파라미터(Type Parameter)로 받아들이도록 클래스를 정의한다. 
 * 이렇게 정의된 클래스 즉 C# 제네릭 타입을 사용할 때는 클래스명과 함께 구체적인 데이타 타입을 함께 지정해 주게 된다. 이렇게 하면 일부 상이한 데이타 타입 때문에 
 * 여러 개의 클래스들을 따로 만들 필요가 없어지게 된다. C# 제네릭은 이렇게 클래스 이외에도 인터페이스나 메서드에도 적용될 수 있다.
 */
namespace _05_Generics
{
    // 어떤 요소 타입도 받아들 일 수 있는
    // 스택 클래스를 C# 제네릭을 이용하여 정의
    class MyStack<T>
    {
        T[] _elements;
        int pos = 0;

        public MyStack()
        {
            _elements = new T[100];
        }

        public void Push(T element)
        {
            _elements[++pos] = element;
        }

        public T Pop()
        {
            return _elements[pos--];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 두 개의 서로 다른 타입을 갖는 스택 객체를 생성
            MyStack<int> numberStack = new MyStack<int>();
            MyStack<string> nameStack = new MyStack<string>();

            List<string> nameList = new List<string>();
            nameList.Add("홍길동");
            nameList.Add("이태백");

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["길동"] = 100;
            dic["태백"] = 90;
        }
    }
}
