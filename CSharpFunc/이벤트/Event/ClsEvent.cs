using CSharpFunc.인터페이스;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.이벤트.Event
{
    class ClsEvent
    {

        ClsWorker1 worker1;
        ClsWorker2 worker2;
        ClsWorker3 worker3;
            
        private void Main()
        {
            worker1.Send(worker2);

            // 이벤트는 +=으로 가르키도록 해야함.
            worker2.OnFull += new ClsWorker2.Full_Delegate(OnFull);
            worker3.OnNotify += new OnNotify_Delegate(OnNotify);
        }
        private void OnNotify()
        { 
        }


        private void OnFull()
        {
            Console.WriteLine("OnFull");
        }

        
    }
}
