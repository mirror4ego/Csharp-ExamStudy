using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C#의 키워드 enum은 열거형 상수(constant)를 표현하기 위한 것으로 이를 이용하면 상수 숫자들을 보다 의미있는 단어들로 표현할 수 있어서 프로그램을 읽기 쉽게 해준다.
 * enum의 각 요소는 별도의 지정없이는 첫번째 요소가 0, 두번째 요소가 1, 세번째 요소가 2 등과 같이 1씩 증가된 값들을 할당받는다. 
 * 물론, 개발자가 임의로 의미있는 번호를 지정해 줄 수도 있다. enum문은 클래스 안이나 네임스페이스 내에서만 선언될 수 있다. 즉, 메서드 안이나 속성 안에서는 선언되지 않는다.
 */

namespace _07_Enum
{
    public enum Category1
    {
        Cake,
        IceCream,
        Bread
    }
    class Program
    {
        public enum Category2
        {
            Cake,
            IceCream,
            Bread
        }

        enum City
        {
            Seoul,   // 0
            Daejun,  // 1
            Busan = 5,  // 5
            Jeju = 10   // 10
        }

        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

        static void Main(string[] args)
        {
            City myCity;

            // enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 변환(Casting)하는 방법. 
            // (int)를 앞에 지정.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) // enum 값을 비교하는 방법
            {
                Console.WriteLine("Welcome to Seoul");
            }

            //Flag Enum
            //enum의 각 멤버들은 각 비트별로 구분되는 값들(예: 1,2,4,8,...)을 갖을 수 있는데, 이렇게 enum 타입이 비트 필드를 갖는다는 것을 표시하기 위해 
            //enum 선언문 바로 위에 [Flags] 라는 Attribute (주: Type 혹은 그 멤버를 선언할 때 그 위에 붙이는 특별한 특성값으로 해당 타입 혹은 멤버가 어떤 특성을 갖고 있는지 나타내게 된다)를 지정할 수 있다.

            // OR 연산자로 다중 플래그 할당
            Border b = Border.Top | Border.Bottom;
            Console.WriteLine(b.ToString());
            Console.WriteLine((b & Border.Left).ToString()); // 비트 연산자를 활용한 것 b = 0011이고 Border.Left = 0100이므로 &비트연산을 하면 0000 이 됨
            // & 연산자로 플래그 체크
            if ((b & Border.Top) != 0)
            {
                //HasFlag()이용 플래그 체크
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" 출력
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}
