using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 정적(Static) 메서드는 인스턴스 메서드와는 달리 클래스로부터 객체를 생성하지 않고 직접 [클래스명.메서드명] 형식으로 호출하는 메서드이다. 
 * 이 메서드는 메서드 앞에 static 이라는 C# 키워드를 적어 주며, 메서드 내부에서 클래스의 인스턴스 객체 멤버를 참조해서는 안된다. 
 * 이 static 메서드는 인스턴스 객체로부터 호출될 수 없으며, 반드시 클래스명과 함께 사용된다. 
 * 
 * 정적(Static) 속성 및 필드는 위의 static 메서드와 같이 [클래스명.속성명]과 같이 사용하며, 다음 예와 같이 static을 앞에 붙여 정의한다. 
 * 클래스 내의 Non-static 필드들은 클래스 인스턴트를 생성할 때마다 메모리에 매번 새로 생성되게 되는 반면, static 필드는 프로그램 실행 후 해당 클래스가 
 * 처음으로 사용될 때 한번 초기화되어 계속 동일한 메모리를 사용하게 된다. 
 * 
 * Static 클래스는 모든 클래스 멤버가 static 멤버로 되어 있으며, 클래스명 앞에 static 이라는 C# 키워드를 사용하여 정의한다. 
 * Static 클래스는 public 생성자(Constructor)를 가질 수 없지만 (왜냐 하면 static 클래스는 객체를 생성할 수 없으므로), static 생성자를 가질 수 있다. 
 * 이 static 생성자는 주로 static 필드들을 초기화 하는데 사용한다. 아래 예제는 static 클래스를 정의하고 사용하는 예이다. 
     */

namespace _04_StaticMethod
{
    public class MyClass
    {
        // static 필드
        protected static int _id;

        // static 속성
        public static string Name { get; set; }

        private int val = 1;

        // 인스턴스 메서드
        public int InstRun()
        {
            return val;
        }

        // 정적(Static) 메서드
        public static int Run()
        {
            return 1;
        }
    }

    public class Client
    {
        public void Test()
        {
            // 인스턴스 메서드 호출
            MyClass myClass = new MyClass();
            int i = myClass.InstRun();

            // 정적 메서드 호출
            int j = MyClass.Run();
        }
    }

    // static 클래스 정의
    public static class MyUtility
    {
        private static int ver;

        // static 생성자
        static MyUtility()
        {
            ver = 1;
        }

        public static string Convert(int i)
        {
            return i.ToString();
        }

        public static int ConvertBack(string s)
        {
            return int.Parse(s);
        }
    }

    // static 클래스 사용
    static void Main(string[] args)
    {
        string str = MyUtility.Convert(123);
        int i = MyUtility.ConvertBack(str);
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
