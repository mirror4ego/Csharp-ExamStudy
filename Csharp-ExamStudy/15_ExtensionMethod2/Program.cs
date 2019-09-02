using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ExtensionMethod2
{
    class Program
    {
        // LINQ에 정의된 Where 확장메서드

        public static IEnumerable<TSource> Where<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate
        )

            // Where 확장메서드를 List<T>에서 사용

        List<string> list = new List<string> { "Apple", "Grape", "Banana" };
        IEnumerable<string> q = list.Where(p => p.StartsWith("A"));

        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 55, 44, 33, 66, 11 };

            // Where 확장 메서드 정수 리스트에 사용
            var v = nums.Where(p => p % 3 == 0);

            // IEnumerable<int> 결과를 정수리스트로 변환
            List<int> arr = v.ToList<int>();

            // 리스트 출력
            arr.ForEach(n => Console.WriteLine(n));
        }
    }
}
