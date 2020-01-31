using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Philosoph
{
    class Philosoph
    {
        public string  Name { get; set; }
        public int EatTime { get; set; }
        public int ThinkTime { get; set; }

        private bool left = false;
        private bool right = false;


        public Philosoph()
        {
            
        }

        public Philosoph(string name,int eatTime, int thinkTime)
        {
            Name = name;
            EatTime = eatTime;
            ThinkTime = thinkTime;
        }

      

        public static void SørenKirkegaard()
        {
            new Philosoph("Søren Kirkegård", 0, 0);

            while (true)
            {
               // keep the thread alive 
            }
        }
        public static void Platon()
        {
            new Philosoph("Platon", 0, 0);

            while (true)
            {
                // keep the thread alive 
            }
        }
        public static void ImmanuelKant()
        {
            new Philosoph("Immanuel Kant", 0, 0);

            while (true)
            {
                // keep the thread alive 
            }
        }
        public static void Aristokeles()
        {
            new Philosoph("Aristokeles", 0, 0);

            while (true)
            {
                // keep the thread alive 
            }
        }
        public static void JeanPaulSartre()
        {
            new Philosoph("Jean-Paul Sartre", 0, 0);

            while (true)
            {
                // keep the thread alive 
            }
        }
    }
}
