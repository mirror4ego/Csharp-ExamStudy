using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*클래스와 비슷하게 인터페이스는 메서드, 속성, 이벤트, 인덱서 등을 갖지만, 인터페이스는 이를 직접 구현하지 않고 단지 정의(prototype definition)만을 갖는다. 
 * 즉, 인터페이스는 추상 멤버(abstract member)로만 구성된 추상 Base 클래스(abstract base class)와 개념적으로 유사하다. 
 * 클래스가 인터페이스를 가지는 경우 해당 인터페이스의 모든 멤버에 대한 구현(implementation)을 제공해야 한다.
 */
namespace _06_Interface
{
    public interface IComparable
    {
        // 멤버 앞에 접근제한자 사용 안함
        int CompareTo(object obj);
    }

    public class MyClass : IComparable
    {
        private int key;
        private int value;

        // IComparable 의 CompareTo 메서드 구현
        public int CompareTo(object obj)
        {
            MyClass target = (MyClass)obj;
            return this.key.CompareTo(target.key);
        }
    }

    public class MyConnection : Component, IDbConnection, IDisposable
    {
        // IDbConnection을 구현
        // IDisposable을 구현
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ConnectionTimeout => throw new NotImplementedException();

        public string Database => throw new NotImplementedException();

        public ConnectionState State => throw new NotImplementedException();

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
