using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class MyThread
    {
        public void Thread1(object state)
        {
            Console.WriteLine(""+Thread.CurrentThread.Name);
            for (int i = 1; i <= 10; i+=2)
                Console.WriteLine("Thread-1: " + i);
        }
        public void Thread2(object state)
        {
            Console.WriteLine("" + Thread.CurrentThread.Name);
            for (int i = 1; i <= 10; i+=2)
                Console.WriteLine("Thread-2: " + i);
        }
    }
    class Summation
    {
        int sum,sum1;
        Mutex mutex = new Mutex();

        public void Sum1To50()
        {
            sum = 0;
            for(int i=1;i<=50;i++)
            {
                mutex.WaitOne();
                sum += i;
                mutex.ReleaseMutex();
            }
            Console.WriteLine("Sum of numbers from 1 to 50 using Thread-1: " + sum);
        }
        public void Sum51To100()
        {
            sum1 = 0;
            Thread.Sleep(1000);
            for (int i = 51; i <= 100; i++)
            {
                mutex.WaitOne();
                sum1 += i;
                mutex.ReleaseMutex();
            }
            Console.WriteLine("Sum of numbers from 51 to 100 using Thread-2: " + sum1);
        }
        public int SummationValues()
        {
            return sum+sum1;
        }
    }
    class ThreadDemo1
    {
        Mutex mut = new Mutex();
        public void Thread1()
        {
            mut.WaitOne();
            Thread.Sleep(1000);
            Console.WriteLine("Inside Thread-1");
            mut.ReleaseMutex();
        }
        public void Thread2()
        {
            mut.WaitOne();
            Console.WriteLine("Inside Thread-2");
            mut.ReleaseMutex();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyThread myThread = new MyThread();

            /*Creating a Thread using Thread class*/
            //Thread Creation
            /*Thread thread1 = new Thread(new ThreadStart(myThread.Thread1));
              thread1.Name = "Thread1";
              Thread thread2 = new Thread(new ThreadStart(myThread.Thread2));
              thread2.Name = "Thread2";

              //Starting the threads 
              thread1.Start();
              thread2.Start();

              //Names of Threads
              Console.WriteLine("Name of Thread1: " + thread1.Name);
              Console.WriteLine("Name of Thread2: " + thread2.Name);

              //Priority of Threads
              Console.WriteLine("Priority of Thread1: " + thread1.Priority);
              Console.WriteLine("Priority of Thread2: " + thread2.Priority);

              //Mainthread will be blocked and these threads will executes first and later Mainthread will execute
              thread1.Join();
              thread2.Join();
              */

            //Creating a Thread using ThreadPool (static class)
            /*ThreadPool.QueueUserWorkItem(myThread.Thread1);
              ThreadPool.QueueUserWorkItem(myThread.Thread2);
              Console.WriteLine("Main Thread Exiting");
            */

            /*
             Summation sum = new Summation();
             Thread t1 = new Thread(new ThreadStart(sum.Sum1To50));
             Thread t2 = new Thread(new ThreadStart(sum.Sum51To100));

             t1.Start();
             t2.Start();

             t1.Join();
             t2.Join();

             Console.WriteLine("Summation from 1 to 100 using MainThread is "+sum.SummationValues());
            */
            
            new ThreadDemo1().Thread1();
            new ThreadDemo1().Thread2();


            Console.ReadLine();
        }
    }
}
