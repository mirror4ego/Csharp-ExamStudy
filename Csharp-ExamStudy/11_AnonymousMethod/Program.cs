using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*만약 어떤 메서드가 일회용으로 단순한 문장들로 구성되어 있다면, 굳이 별도의 메서드를 정의하지 않아도 되는 것이다.
*/

// 무명메서드를 delegate 타입 변수에 할당

delegate void MyDelegate(int a);

MyDelegate d = delegate (int p)
{
    Console.Write(p);
};

d(100);

namespace _11_AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // 무명메서드 형식: delegate(파라미터들) { 실행문장들 };

        delegate (int param1) { Console.Write(param1); };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 메서드명을 지정
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 무명메서드를 지정
            this.button2.Click += delegate (object s, EventArgs e)
            {
                MessageBox.Show("버튼2 클릭");
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼1 클릭");
        }

        // Delegate 타입 : 
        public delegate int SumDelegate(int a, int b);

        // Delegate 사용 : 
        SumDelegate sumDel = new SumDelegate(mySum);

        // 무명메서드1 
        button1.Click += new EventHandler(delegate (object s, EventArgs a) { MessageBox.Show("OK"); });

        // 무명메서드2
        button1.Click += (EventHandler) delegate (object s, EventArgs a) { MessageBox.Show("OK"); };

        // 무명메서드3 
        button1.Click += delegate (object s, EventArgs a) { MessageBox.Show("OK"); };

        // 무명메서드4 
        button1.Click += delegate { MessageBox.Show("OK"); };


            // 틀림: 컴파일 에러 발생
        this.Invoke(delegate {button1.Text = s;} );

        // 맞는 표현 
        MethodInvoker mi = new MethodInvoker(delegate () { button1.Text = s; });
        this.Invoke(mi);

        // 축약된 표현
        this.Invoke((MethodInvoker) delegate { button1.Text = s; });

        /* 
        MethodInvoker는 입력 파라미터가 없고, 리턴 타입이 void인 델리게이트이다.
        MethodInvoker는 System.Windows.Forms 에 다음과 같이 정의되어 있다.

        public delegate void MethodInvoker();
        */
    }
}



