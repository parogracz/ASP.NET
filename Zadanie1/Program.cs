using System;
using System.Reflection;

namespace Zadanie1
{
    class Testowy
    {
        int hades;
        int ostr;
        string szad;
        bool pork;
        float nullo;

        public Testowy(int hades, int ostr, string szad, bool pork, float nullo)
        {
            this.hades = hades;
            this.ostr = ostr;
            this.szad = szad;
            this.pork = pork;
            this.nullo = nullo;
            Console.WriteLine("Stworzono Testowego!");
        }

        public int Metoda1(int x, long id)
        {
            return x;
        }

        public int Metoda1(int x)
        {
            return x;
        }
        public string Metoda2()
        {
            return string.Empty;
        }
        public override string ToString()
        {
            return hades + " " + szad;
        }
        public bool Metoda3(long id)
        {
            return false;
        }
    }
    class Program
    {
        public static int CountMethods(Type t)
        {
            int count = 0;
            MethodInfo[] methods = t.GetMethods();

            foreach (MethodInfo m in methods)
            {
                ParameterInfo[] parametrs = m.GetParameters();
                foreach (ParameterInfo p in parametrs)
                {
                    if (p.Name.ToString() == "id" && p.ParameterType.Name.ToString() == "Int64")
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Testowy t = new Testowy(1,2,"tekst", false, 1.3f);
            Console.WriteLine(CountMethods(t.GetType()));
        }
    }
}
