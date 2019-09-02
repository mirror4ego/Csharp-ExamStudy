using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*c#에서 변수는 메서드 안에서 로컬변수로 선언되거나, 클래스 안에서 클래스 내의 멤버들이 사용하는 전역변수(필드)로 선언 가능함.
 * 로컬변수는 사용 후 소멸, 필드는 클래스의 객체가 살아있는 한 존속하며 다른 메서드들에서 필드 참조 가능
 * 필드가 정적 필드이면 클래스 타입이 처음으로 런타임에 의해 로드될때 생성되어 프로그램이 종료될 때까지 유지됨
 * 로컬변수는 사용전 반드시 값 할당 필요, 필드는 해당타입의 기본값이 자동으로 할당됨.
 * 대소문자 구별 함
 */

namespace _04_Variable
{
    class CSVar
    {
        //필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar; // 전역변수에서 값 할당이 없었으므로 디폴트 값인 0이 들어감

        // 상수
        const int MAX = 1024; // 상수 이므로 초기에 정한 값을 변경 할 수 없음. 생성자에서 초기화 불가능

        // readonly 필드 
        readonly int Max1 = 1040;
        readonly int Max;
        public CSVar() // 생성자에서 readonly 필드 초기화 가능
        {
            Max = 1;
        }

        public void Method1()
        {
            // 로컬변수
            int localVar;

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        // 모든 프로그램에는 Main()이 있어야 함.
        static void Main(string[] args)
        {
            // 테스트
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}
