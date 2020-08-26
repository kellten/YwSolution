using CSharpFunc.인터페이스;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.이벤트.Event
{
    class ClsWorker1
    {

        //public void Send(ClsWorker2 worker2)
        public void Send(IWorker worker2)
        {
            worker2.Receive();
        }
    }
}
