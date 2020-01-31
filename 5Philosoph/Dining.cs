using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5Philosoph
{
    class Dining
    {

        public static ObservableCollection<Thread> threadTracker = new ObservableCollection<Thread>();
        public static void ThreadStarter()
        {
            Console.WriteLine("Overview over threads\n");

            Thread firstThread = new Thread(Philosoph.SørenKirkegaard);

            Thread secondThread = new Thread(Philosoph.Aristokeles);

            Thread thirdThread = new Thread(Philosoph.ImmanuelKant);

            Thread fourthThread = new Thread(Philosoph.JeanPaulSartre);

            Thread fiftThread = new Thread(Philosoph.Platon);

            firstThread.Start();
            threadTracker.Add(firstThread);

            secondThread.Start();
            threadTracker.Add(secondThread);

            thirdThread.Start();
            threadTracker.Add(thirdThread);

            fourthThread.Start();
            threadTracker.Add(fourthThread);

            fiftThread.Start();
            threadTracker.Add(fiftThread);

            foreach (Thread threads in threadTracker)
            {
                Console.WriteLine($"Thread: {threads.ManagedThreadId} State: {threads.ThreadState} Priority: {threads.Priority}");

            }
        }
      
    }
}
