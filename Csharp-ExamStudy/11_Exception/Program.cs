using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 실행하고자 하는 문장들
                DoSomething();
            }
            catch (Exception ex)
            {
                // 에러 처리/로깅 등
                Log(ex);
                throw;
            }

            try
            {
                //실행 문장들
            }
            catch (ArgumentException ex)
            {
                // Argument 예외처리
            }
            catch (AccessViolationException ex)
            {
                // AccessViolation 예외처리
            }
            finally
            {
                // 마지막으로 실행하는 문장들
            }

            try
            {
                // 실행 문장들
                Step1();
                Step2();
                Step3();
            }
            catch (IndexOutOfRangeException ex)
            {
                // 새로운 Exception 생성하여 throw
                throw new MyException("Invalid index", ex);
            }
            catch (FileNotFoundException ex)
            {
                bool success = Log(ex);
                if (!success)
                {
                    // 기존 Exception을 throw
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Log(ex);
                // 발생된 Exception을 그대로 호출자에 전달
                throw;
            }

            string connStr = "Data Source=(local);Integrated Security=true;";
            string sql = "SELECT COUNT(1) FROM sys.objects";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null &&
                    conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
