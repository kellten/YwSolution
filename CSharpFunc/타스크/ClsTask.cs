using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunc.타스크
{
    class ClsTask
    {
        //private bool TaskMuti()
        //{
        //    // Parent/Child Task로의 연결, TaskCreationOptions.AttachedToParent
        //    Task<Int32[]> parent = new Task<Int32[]>(() =>
        //    {
        //        var results = new Int32[3];
        //        new Task(() => // 차일드로 연결
        //        results[0] = Sum(10), TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => // 차일드로 연결
        //        results[1] = Sum(20), TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => // 차일드로 연결
        //        results[2] = Sum(30), TaskCreationOptions.AttachedToParent).Start();
        //        return results;
        //    });
        //    var cwt = parent.ContinueWith( // parent Task가 끝나면 수행할 Task 연결
        //    parentTask => Array.ForEach(parentTask.Result, Console.WriteLine));
        //    parent.Start();
        //}

        private void TaskSingle()
        {
            // t Task가완료되면cwt Task를수행한다.
            
            //Task<Int32> t = Task.Run(() => 
            //Sum(CancellationToken.None, 100));

            //Taskcwt = t.ContinueWith(task => Console.WriteLine("The sum is: "+ task.Result));
        }

        private int Sum(int a)
        {
            return a;
        }

    }
  
}
