using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 배열은 동일한 데이타 타입 요소들로 구성된 데이타 집합
 * 첫번째 요소는 인덱스 0임 A[0]
 */

namespace _05_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1차 배열
            string[] players = new string[10];
            string[] Regions = { "서울", "경기", "부산" };

            // 2차 배열 선언 및 초기화
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            // 3차 배열 선언
            string[,,] Cubes;

            //가변배열
            // 각 차원별 배열 요소 크기가 가변적인 가변 배열(Jagged Array)의 경우 [][] 와 같이 각 차원마다 괄호를 별도로 사용한다 (Java 언어 스타일).
            //가변 배열은 배열의 배열(array of arrays)이라 불리우는데, 첫번째 차원의 크기는 컴파일 타임에 확정되어야 하고, 그 이상 차원은 런타임시 동적으로 서로 다른 크기의 배열로 지정할 수 있다. 
            //이러한 가변 배열은 각 차원별 배열 요소가 불규칙하여 Rectangular 배열처럼 고정된 크기를 사용하면 메모리의 낭비가 심한 경우에 사용하면 유용하다. 
            //Jagged Array (가변 배열)
            //1차 배열 크기(3)는 명시해야
            int[][] A = new int[3][];

            //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            // 배열의 사용
            // 배열은 .NET Framework의 System.Array에서 파생된 것이므로 Array의 메서드 플로퍼티를 사용 가능
            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum);

            // 배열의 전달
            // 배열은 레퍼런스(Reference) 타입이기 때문에, 배열을 다른 객체나 메서드에 전달할 때, 직접 모든 배열 데이타를 복사하지 않고, 
            // 배열 전체를 가리키는 참조 값(Reference pointer)만을 전달한다. 즉, 전달하는 쪽에서는 단순히 레퍼런스인 배열명을 사용하며, 
            // 받는 쪽에서는 아래 예제와 같이 배열 데이타 타입 및 배열 파라미터명을 사용
            int[] scores1 = { 80, 78, 60, 90, 100 };
            int sum1 = CalculateSum(scores1); // 배열 전달: 배열명 사용
            Console.WriteLine(sum1);
        }

        static int CalculateSum(int[] scoresArray) // 배열 받는 쪽
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }
    }
}
