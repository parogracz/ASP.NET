using System;
using System.Reflection;

namespace Zadanie1
{
    public class Program
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
        }
    }
}
