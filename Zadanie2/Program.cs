using System;
using System.Diagnostics;
using System.Threading;

namespace Zadanie2
{
    class Program
    {
        /// <summary>
        /// Wypisywać powinno 0.
        /// Program odpala stoper, tworzy 60 wątków, zadaniem każdego z wątków jest się zawiesić na 1000ms.
        /// Wątki odrazu po uruchomieniu są synchronizowane więc przed odpaleniem kolejnego system czeka sekundę.
        /// Stoper w ten sposób czeka 60 x 1sek, na koniec wypisujemy jego wynik w sekundach o okresie od 0 do 59.
        /// Reprezentacja 60 to 0.
        /// 
        /// threads[i].Start();
        /// threads[i].Join();
        /// Nie ma to większego sensu, wątek jest startowany i odrazu synchronizowany do wątka głównego. 
        /// Żeby wątki działały równolegle należy pozbyć się Join`a.
        /// </summary>
        static void Metoda()
        {
            const int count = 60;
            var threads = new Thread[count];
            var timer = new Stopwatch();

            timer.Start();

            for (int i = 0; i < count; i++)
            {
                threads[i] = new Thread(() => Thread.Sleep(1000));
                threads[i].Start();
                threads[i].Join();
            }
            Console.WriteLine(timer.Elapsed.Seconds);
        }
        static void Main(string[] args)
        {
            Metoda();
        }
    }
}
