using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력 파라미터가 없는 경우
            () => Write("No");

            // 입력 파라미터가 1~2개 있는 경우
            (p) => Write(p);
            (s, e) => { Write(s); Write(e); }

            // 입력 파라미터 타입을 명시하는 경우
            (string s, int i) => Write(s, i);

            // 간단한 이벤트핸들러를 람다식으로 표현한 경우

            this.button1.Click += (sender, e) => ((Button)sender).BackColor = Color.Red;

            // LINQ Where() 메서드 안에서 사용된 람다식

            var projs = db.Projects.Where(p => p.Name == strName);
        }
    }
}
