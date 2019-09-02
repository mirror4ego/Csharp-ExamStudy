using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtendedClass
{
    // 베이스 클래스
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // 파생클래스
    public class Dog : Animal
    {
        public void HowOld()
        {
            // 베이스 클래스의 Age 속성 사용
            Console.WriteLine("나이: {0}", this.Age);
        }
    }

    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("{0}가 날다", this.Name);
        }
    }
    

    //추상클래스
    public abstract class PureBase
    {
        // abstract C#키워드 
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DerivedA : PureBase
    {
        private int no = 1;

        // override C#키워드 
        public override int GetFirst()
        {
            return no;
        }

        public override int GetNext()
        {
            return ++no;
        }
    }

    // AS IS 연산자
    //C#의 as 연산자는 객체를 지정된 클래스 타입으로 변환하는데 사용한다. 만약 변환이 성공하면 해당 클래스 타입으로 캐스팅하고, 변환이 실패하면 null 을 리턴한다. 
    //이와는 대조적으로 캐스팅(Casting)을 사용하면, 변환이 실패했을 때 Exception을 발생시키게 되는데, 이를 catch하지 않으면 프로그램을 중지하게 된다.
    //C#의 is 연산자는 is 앞에 있는 객체가 특정 클래스 타입이나 인터페이스를 갖고 있는지 확인하는데 사용한다. 
    class MyBase { }
    class MyClass : MyBase { }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            new Program().Test(c);
        }

        public void Test(object obj)
        {
            // as 연산자
            MyBase a = obj as MyBase;

            // is 연산자
            bool ok = obj is MyBase; //true

            // Explicit Casting
            MyBase b = (MyBase)obj;
        }
    }
}
