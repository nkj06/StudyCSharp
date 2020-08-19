using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _625_InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running thread isn't gonna be interrupted");
                Thread.SpinWait(1000000000);

                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(100);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                SideTask task = new SideTask(100);
                Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
                t1.IsBackground = false;

                Console.WriteLine("Starting thread...");
                t1.Start();

                Thread.Sleep(1000);

                Console.WriteLine("Aborting thread...");
                t1.Abort();

                Console.WriteLine("Wating until thread stops...");
                t1.Join();

                Console.WriteLine("Finished");
            }
        }
    }
}
