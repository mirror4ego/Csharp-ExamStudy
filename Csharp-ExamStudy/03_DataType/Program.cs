using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* C#의 데이타 표현 :  c#키워드로 표현할수 있음. 또한 .NET 데이타 클래스로 데이타 타입 표현 가능. 
 * 리터럴 데이타 : 값을 직접 써줄때의 데이터
 *      별도 타입지정 접미사가 없는 경우 : 정수는 int, 소수점아래값이 있는 경우 double, 쌍따옴표 안의 값은 string, 따옴표 안의 값은 char, true&false는 bool
 *      타입 지정 접미사는 L,U,UL,F,D,M 등 있으며 대소문자 가능 
 */

namespace _03_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bool
            bool b = true;

            // Numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;      // L suffix
            float f = 123.45F;   // F suffix
            double d1 = 123.45;
            double d2 = 123.45D; // D suffix
            decimal d = 123.45M; // M suffix

            // Char/String
            char c = 'A';
            string s = "Hello";

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            //숫자형 데이타 타입의 최대값 및 최소값을 알아낼 수 있음
            int i1 = int.MaxValue;
            float f1 = float.MinValue;

            // null 은 어떤 데이타도 가지고 있지 않다는 의미로 사용
            // 데이타 타입은 NULL을 가질 수 있는 타입 (Reference 타입)과 가질 수 없는 타입 (Value 타입)으로 구분됨
            string s1;
            s1 = null; // null 할당 가능
            int a;
            a = null; // null 할당 불가능

            //Nullable Type : 정수(int)나 날짜(DateTime)와 같은 Value Type은 일반적으로 NULL을 가질 수 없다. C# 2.0에서부터 이러한 타입들에 NULL을 가질 수 있게 하였는데, 이를 Nullable Type
            //C#에서 물음표(?)를 int나 DateTime 타입명 뒤에 붙이면 즉, int? 혹은 DateTime? 같이 하면 Nullable Type이 된다. 이는 컴파일하면 .NET의 Nullable<T> 타입으로 변환된다. 
            // Nullable Type (예: int?) 을 일반 Value Type (예: int)으로 변경하기 위해서는 Nullable의 .Value 속성을 사용
            int? i2 = null;
            i2 = 101;

            bool? b2 = null;

            //int? 를 int로 할당
            Nullable<int> j3 = null;
            j3 = 10;
            int k3 = j3.Value;

            // value Type 데이터에 Null형으로 만들어주는 이유 : 한가지 예를 들면, 데이타베이스에 NULL이 허용된 INT 컬럼이 있을 때 C#에서 int? 로 매핑할 수 있습니다.
        }
    }
}
