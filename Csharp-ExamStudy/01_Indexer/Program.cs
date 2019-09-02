using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C# Indexer는 클래스 객체의 데이타를 배열 형태로 인덱스를 써서 엑세스할 수 있게 해준다. 
 * 즉, 클래스 객체는 배열이 아님에도 불구하고, 마치 배열처럼 []를 사용하여 클래스 내의 특정 필드 데이타를 엑세스하는 것
 */

namespace _01_Indexer
{
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        // 내부의 정수 배열 데이타
        private int[] data = new int[MAX];

        // 인덱서 정의. int 파라미터 사용
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    // 정수배열로부터 값 리턴
                    return data[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= MAX))
                {
                    // 정수배열에 값 저장
                    data[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();

            // 인덱서 set 사용
            cls[1] = 1024;

            // 인덱서 get 사용
            int i = cls[1];
        }
    }
}
