using CSharpFunc.인터페이스;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.이벤트.Event
{
    class ClsWorker3 : INotifyC
    {
        public event OnNotify_Delegate OnNotify;

        public ClsWorker3()
        {
            OnNotify();
        }
    }
       
}
