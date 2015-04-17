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
    public class UpdateEmployeeNameInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("UpdateEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            // originally, this is object type which is the super class to normalclass
            // but object just represent the super class... it can't do anything..
            // this is just like java you can do force-conversion
            // to convert to class Employee to access the .Name property
            Employee result = (Employee)invocation.Proceed();
            result.Name += " You are so Handsome....";// modify here XD

            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);

            return result;// still can return by type : Employee
        }
    }
}