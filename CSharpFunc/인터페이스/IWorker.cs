using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.인터페이스
{
    public interface IWorker
    {
        void Receive();
    }
    public interface ITest
    {
        void Rrr();
    }
    public delegate void OnNotify_Delegate();
    public interface INotifyC
    {
        event OnNotify_Delegate OnNotify;
    }
}
