using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 기존의 비동기 프로그래밍 (asynchronous programming)을 보다 손쉽게 지원하기 위해 C# 5.0에 추가된 중요한 기능이다.
 */
namespace _18_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();  //UI Thread에서 실행
        }

        private async void Run()
        {
            // 비동기로 Worker Thread에서 도는 task1
            // Task.Run(): .NET Framework 4.5+
            var task1 = Task.Run(() => LongCalcAsync(10));

            // task1이 끝나길 기다렸다가 끝나면 결과치를 sum에 할당
            int sum = await task1;

            // UI Thread 에서 실행
            // Control.Invoke 혹은 Control.BeginInvok 필요없음
            this.label1.Text = "Sum = " + sum;
            this.button1.Enabled = true;
        }

        private int LongCalcAsync(int times)
        {
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();  //UI Thread에서 실행
        }

        private async void Run()
        {
            int sum = await LongCalc2(10);
            this.label1.Text = "Sum = " + sum;
            this.button1.Enabled = true;
        }

        private async Task<int> LongCalc2(int times)
        {
            //UI Thread에서 실행
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += i;
                await Task.Delay(1000);
            }
            return result;
        }

        private void Run2()
        {
            var task1 = Task<int>.Run(() => LongCalc2(10));

            // await task1과 동일한 효과
            //
            task1.ContinueWith(x => {
                this.label1.Text = "Sum = " + task1.Result;
                this.button1.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

    }
}
