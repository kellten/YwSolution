using CSharpFunc.인터페이스;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.이벤트.Event
{
    class ClsWorker2:IWorker, ITest
    {
        public delegate void Full_Delegate();
        public event Full_Delegate OnFull;

        int _m_nCount = 0;
        public void Receive()
        {
            _m_nCount++;

            if (_m_nCount == 5)
            {
                // 이벤트 발생...
                OnFull();
            }
        }

        void ITest.Rrr()
        {
            throw new NotImplementedException();
        }
    }
}
