//#define TEST_ENV
#define PROD_ENV

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C# 전처리기 지시어 (Preprocessor Directive)는 실제 컴파일이 시작되기 전에 컴파일러에게 특별한 명령을 미리 처리하도록 지시하는 것이다.
 * 모든 C# 전처리기 지시어는 # 으로 시작되며, 한 라인에 한 개의 전처리기 명령만을 사용한다. 전처리기 지시어는 C# Statement가 아니기 때문에 끝에 세미콜론(;)을 붙이지 않는다.
 * 
 * C# 전처리기에서 자주 사용되는 것으로 #define과 #if ... #else ... #endif 가 있다
 * 
 * #region 전처리기 지시어 
 * 
 * #undef 는 #define과 반대로 지정된 심벌을 해제 할 때 사용한다.
#elif 는 #if와 함께 사용하여 else if를 나타낸다.
#line 은 거의 사용되진 않지만, 라인번호를 임의로 변경하거나 파일명을 임의로 다르게 설정할 수 있게 해준다.
#error 는 전처리시 Preprocessing을 중단하고 에러 메시지를 출력하게 한다.
#warning 은 경고 메서지를 출력하지만 Preprocessing은 계속 진행한다.
warning과 error는 특정 컴포넌트가 어떤 환경에서 실행되지 않아야 할 때 이를 경고나 에러를 통해 알리고자 할 때 사용될 수 있다.
 */
namespace _18_Preprocessor
{

    class ClassA
    {
        #region Public Methods        
        public void Run() { }
        public void Create() { }
        #endregion

        #region Public Properties
        public int Id { get; set; }
        #endregion

        #region Privates
        private void Execute() { }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool verbose = false;
            // ...

#if (TEST_ENV)
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#else
            Console.WriteLine("Production");
#endif

            if (verbose)
            {
                //....
            }
        }
    }
}


// #warning 예제 -----------------------------------
#if (!ENTERPRISE_EDITION)
#warning This class should be used in Enterprise Edition
#endif

namespace App1
{
    class EnterpriseUtility
    {
    }
}

// #error 예제 --------------------------------------
#define STANDARD_EDITION
#define ENTERPRISE_EDITION

#if (STANDARD_EDITION && ENTERPRISE_EDITION)
#error Use either STANDARD or ENTERPRISE edition. 
#endif

namespace App1
{
    class Class1
    {
    }
}

// CS3021 Warning을 Disable
#pragma warning disable 3021

namespace App1
{
    [System.CLSCompliant(false)]
    class Program
    {
        static void Main(string[] args)
        {
            //...

#pragma warning disable
            if (false)
            {
                Console.WriteLine("TBD");
            }
#pragma warning restore

            //...
        }
    }
}