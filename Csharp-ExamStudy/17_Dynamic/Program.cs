using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Dynamic
{


    class Program
    {
        static void Main(string[] args)
        {
            // 1. dynamic은 중간에 형을 변환할 수 있다.

            dynamic v = 1;
            // System.Int32 출력
            Console.WriteLine(v.GetType());

            v = "abc";
            // System.String 출력
            Console.WriteLine(v.GetType());


            // 2. dynamic은 cast가 필요없다

            object o = 10;
            // 틀린표현
            // (에러: Operator '+' cannot be applied to operands of type 'object' and 'int')
            o = o + 20;
            // 맞는 표현: object 타입은 casting이 필요하다
            o = (int)o + 20;

            // dynamic 타입은 casting이 필요없다.
            dynamic d = 10;
            d = d + 20;
        }
    }

    // 동일 어셈블리에서 익명타입에 dynamic 사용한 경우
    class Class1
    {
        public void Run()
        {
            dynamic t = new { Name = "Kim", Age = 25 };

            var c = new Class2();
            c.Run(t);
        }
    }

    class Class2
    {
        public void Run(dynamic o)
        {
            // dynamic 타입의 속성 직접 사용
            Console.WriteLine(o.Name);
            Console.WriteLine(o.Age);
        }
    }

    //ExpandoObject
    public class Myclass
    {
        public void M1()
        {
            // ExpandoObject에서 dynamic 타입 생성
            dynamic person = new ExpandoObject();

            // 속성 지정
            person.Name = "Kim";
            person.Age = 10;

            // 메서드 지정
            person.Display = (Action)(() =>
            {
                Console.WriteLine("{0} {1}", person.Name, person.Age);
            });

            person.ChangeAge = (Action<int>)((age) => {
                person.Age = age;
                if (person.AgeChanged != null)
                {
                    person.AgeChanged(this, EventArgs.Empty);
                }
            });

            // 이벤트 초기화
            person.AgeChanged = null; //dynamic 이벤트는 먼저 null 초기화함

            // 이벤트핸들러 지정
            person.AgeChanged += new EventHandler(OnAgeChanged);

            // 타 메서드에 파라미터로 전달
            M2(person);

            public void M1()
            {
                dynamic person = new ExpandoObject();
                person.Name = "Kim";
                person.Age = 10;
                person.Display = (Action)(() => { });
                person.ChangeAge = (Action<int>)((age) => { person.Age = age; });
                person.AgeChanged = null;
                person.AgeChanged += new EventHandler((s, e) => { });

                // ExpandoObject를 IDictionary로 변환
                var dict = (IDictionary<string, object>)person;

                // person 의 속성,메서드,이벤트는
                // IDictionary 해시테이블에 저정되어 있는데
                // 아래는 이를 출력함
                foreach (var d in dict)
                {
                    Console.WriteLine("{0}: {1}", d.Key, d.Value);
                }
            }
        }

        private void OnAgeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Age changed");
        }

        // dynamic 파라미터 전달받음
        public void M2(dynamic d)
        {
            // dynamic 타입 메서드 호출 
            d.Display();
            d.ChangeAge(20);
            d.Display();
        }
    }

}
