using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6
{
    public delegate void Notification();
    class ProcessBusinessLogic
    {
        public event Notification ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
           
            ProcessCompleted?.Invoke();
        }

        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }

        public static void Main()
        {
            ProcessBusinessLogic pbl = new ProcessBusinessLogic();
            pbl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            pbl.StartProcess();
        }

    }
}
