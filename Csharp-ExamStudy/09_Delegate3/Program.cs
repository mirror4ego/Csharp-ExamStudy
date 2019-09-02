using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Delegate의 문제점 : 할당 연산자를 잘못사용하면 등록했던 메소드 리스트를 지워버리게 됨
 * 외부에서 실수로 호출 가능
 * 
 * event는 할당연산자를 사용 못하며 외부에서 이벤트를 호출 불가하다
 */

namespace _10_Delegate3
{
    class MyArea : Form
    {
        public MyArea()
        {
            // 이 부분은 당분간 무시. (무명메서드 참조)
            // 예제를 테스트하기 위한 용도임.
            this.MouseClick += delegate { MyAreaClicked(); };
        }

        public delegate void ClickEvent(object sender);

        // event 필드
        public event ClickEvent MyClick;

        // 예제를 단순화 하기 위해
        // MyArea가 클릭되면 아래 함수가 호출된다고 가정
        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                MyClick(this);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            area = new MyArea();

            area.MyClick += Area_Click;
            area.MyClick += AfterClick;

            area.Show();

            // 덮어쓰기: MyClick은 Area_Click메서드만 갖는다
            area.MyClick = Area_Click;

            // C# delegate는 클래스 외부에서 호출할 수 있다.
            // C# event는 불가
            area.MyClick(null);
            area = new MyArea();

            // 이벤트 가입
            area.MyClick += Area_Click;
            area.MyClick += AfterClick;

            // 이벤트 탈퇴
            area.MyClick -= Area_Click;

            // Error: 이벤트 직접호출 불가
            //area.MyClick(this);

            area.ShowDialog();
        }

        static void Area_Click(object sender)
        {
            area.Text += " MyArea 클릭! ";
        }

        static void AfterClick(object sender)
        {
            area.Text += " AfterClick 클릭! ";
        }
    }
}



/*
 C# delegate는 메서드의 레퍼런스를 갖고 있다는 점에서 C의 함수 포인터(function pointer)와 닮았다. 하지만 C# delegate는 몇 가지 측면에서 C의 함수 포인터와 다르다.

첫번째로 클래스의 개념이 없는 C에서의 함수 포인터는 말 그대로 외부의 어떤 함수에 대한 주소값만을 갖는다. 반면 C#의 delegate는 클래스 객체의 인스턴스 메서드에 대한 레퍼런스를 갖기 위해 
그 C# 객체의 주소(객체 레퍼런스)와 메서드 주소를 함께 가지고 있다. (주: 물론 Static 메서드의 경우에는 객체의 레퍼런스값이 null 이 된다) C# delegate는 델리게이트 Type을 정의하는 것으로 이 
Type으로부터 델리게이트 객체를 생성할 때, 이 객체가 메서드 정보와 객체 정보를 가진다.

클래스를 사용하는 C++에는 Pointer to member function이 있는데, 이는 한 클래스의 멤버 함수에 대한 포인터로서 '객체'에 대한 컨텍스트를 가지고 있다는 점에서 C#의 delegate와 비슷하다. 단, 
C#의 delegate는 메서드 Prototype이 같다면 어느 클래스의 메서드도 쉽게 할당할 수 있는데 반해, C++의 Pointer to member는 함수 포인터 선언시 특정 클래스를 지정해주기 때문에 한 클래스에 
대해서만 사용할 수 있다.

두번째로 C의 함수 포인터는 하나의 함수 포인터를 갖는데 반해, C# delegate는 하나 이상의 메서드 레퍼런스들을 가질 수 있어서 Multicast가 가능하다.

또한 C의 함수포인터는 Type Safety를 완전히 보장하지 않는 반면, C#의 delegate는 엄격하게 Type Safety를 보장한다. 
     */

// C 함수 포인터 예제

void myfunc(int x)
{
    printf("%d\n", x);
}

void main()
{
    // 함수포인터 f 정의
    void(*f)(int);

    // 함수포인터에 함수 지정
    f = &myfunc;

    // 함수 실행
    f(2);
}


// C++ Pointer to member 예제
#include <iostream>
#include <string>
class Cls
{
    public:
    // 클래스 메서드 멤버
    void myfunc(std::string str)
    {
        std::cout << str << std::endl;
    }
};

void main()
{
    // Pointer to member function 정의
    void(Cls::* fp)(std::string);

    // Pointer to member 지정
    fp = &Cls::myfunc;

    // Cls 객체 생성 및 객체 포인터 지정
    Cls obj;
    Cls* pObj = &obj;

    // Cls 객체에서 함수포인터 사용
    (pObj->* fp)("hello");
}


