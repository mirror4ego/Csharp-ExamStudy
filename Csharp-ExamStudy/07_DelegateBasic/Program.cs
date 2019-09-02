using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Delegate는 이렇게 메서드를 다른 메서드로 전달할 수 있도록 하기 위해 만들어 졌다. 
 * 아래 그림에서 보이듯이, 숫자 혹은 객체를 메서드의 파라미터로써 전달할 수 있듯이, 메서드 또한 파라미터로서 전달할 수 있다. (주: 복수 개의 메서드들도 전달 가능) 
 * Delegate는 메서드의 입력 파라미터로 피호출자에게 전달될 수 있을 뿐만 아니라, 또한 메서드의 리턴값으로 호출자에게 전달 수도 있다.
 */

namespace _07_DelegateBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
        }

        delegate int MyDelegate(string s);

        void Test()
        {
            // 델리게이트 객체 생성
            MyDelegate m = new MyDelegate(StringToInt);

            //델리게이트 객체를 메서드로 전달
            Run(m);
        }

        //델리게이트 대상이 되는 어떤 메서드
        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        //델리게이트를 전달 받는 메서드
        void Run(MyDelegate m)
        {
            //델리게이트로부터 메서드 실행
            int i = m("123");
            Console.WriteLine(i);
        }
    }
}
