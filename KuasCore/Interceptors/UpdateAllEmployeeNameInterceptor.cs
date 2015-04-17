using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Interceptors
{
    public class UpdateAllEmployeeNameInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("UpdateAllEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateAllEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            /*extra trial*/
            IList<Employee> result = (IList<Employee>)invocation.Proceed();
            for (int i = 0; i < result.Count; i++)
            {
                Debug.Print(result[i].Name);
                result[i].Name += " HAHAHA" + i;
            }

            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);

            return result;
        }
    }
}