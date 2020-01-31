using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5Philosoph
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5 stille filosoffer sidder og spekluere rundt om et bord
             mellem hver af dem ligger der en gaffel 5 i alt, Filosofferne samler en gaffel op og beholder den til den anden er ledig når en filosof har 2 gafler spiser han for en stund og lægger gaflerne ned 
             det munder ud i en deadlock og den skal i skabe*/

            ObservableCollection<Thread> threadTracker = new ObservableCollection<Thread>();

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



            Console.Read();
        }
    }
}
