using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C#에서 int? 와 같이 해당 Value Type 뒤에 물음표를 붙이면, 해당 정수형 타입이 Nullable 정수형 타입임을 의미한다. 
 * 즉, 이 변수에는 NULL을 할당할 수 있다. C#의 이러한 특별한 문법은 .NET의 Nullable<T> 구조체로 컴파일시 변환된다. 즉, int?는 Nullable<int>와 동일하다
 */
namespace _15_Nullable
{
    class Program
    {
        double _Sum = 0;
        DateTime _Time;
        bool? _Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
                this._Sum = (double)i.Value + (double)d.Value;

            // time값이 있는 체크.
            if (!time.HasValue)
                throw new ArgumentException();
            else
                this._Time = time.Value;

            // 만약 selected가 NULL이면 false를 할당
            this._Selected = selected ?? false;
        }

        void NullableTest()
        {
            int? a = null;
            int? b = 0;
            int result = Nullable.Compare<int>(a, b);
            Console.WriteLine(result); //결과 -1

            double? c = 0.01;
            double? d = 0.0100;
            bool result2 = Nullable.Equals<double>(c, d);
            Console.WriteLine(result2); //결과 true
        }

        static void Main(string[] args)
        {
            int? i = null;
            bool? b = null;
            int?[] a = new int?[100];
        }
    }
}
