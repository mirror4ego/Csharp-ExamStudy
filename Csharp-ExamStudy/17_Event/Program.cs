using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*이벤트는 클래스내에 특정한 일(event)이 있어났음을 외부의 이벤트 가입자(subscriber)들에게 알려주는 기능을 한다. 
 * C#에서 이벤트는 event라는 키워드를 사용하여 표시하며, 클래스 내에서 일종의 필드처럼 정의된다.
 */
namespace _17_Event
{
    // 클래스 내의 이벤트 정의
    class MyButton
    {
        public string Text;
        // 이벤트 정의
        public event EventHandler Click;

        public void MouseButtonDown()
        {
            if (this.Click != null)
            {
                // 이벤트핸들러들을 호출
                Click(this, EventArgs.Empty);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 클릭");
        }

        public void Run()
        {
            MyButton btn = new MyButton();
            // Click 이벤트에 대한 이벤트핸들러로
            // btn_Click 이라는 메서드를 지정함
            btn.Click += new EventHandler(btn_Click); // 이벤트 핸들러 지정, Click 이벤트가 일어나면 btn_Click 메소드가 호출되게 된다.
            btn.Text = "Run";
            //....
        }
    }
}
