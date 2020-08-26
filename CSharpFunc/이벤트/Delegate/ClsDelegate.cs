using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.이벤트.Delegate
{
    class ClsDelegate
    {
        int add(int a, int b)
        {
            return a + b;
        }

        int minus(int a, int b)
        {
            return a - b;
        }

        delegate int Cal_delegate(int a, int b);

        private void Exec()
        {
            Cal_delegate calDe = new Cal_delegate(add);

            int i = calDe(1, 2);

            Cal_delegate calDeAdd = new Cal_delegate(add);
            Cal_delegate calDeMin = new Cal_delegate(minus);
            
            Cal_delegate allDel = calDeAdd; // add함수 가르킴
            allDel += calDeMin; // add함수 + minus함수가 차례로 실행
            allDel -= calDeAdd; // add함수 + minus함수에서 add함수를 뺌.





        }
    }
}
