using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie1;
using System;
using Xunit;

namespace xUnit
{
    class Testowy
    {
        int przedmiot1;
        int przedmiot2;
        string przedmiot3;
        bool przedmiot4;
        float przedmiot5;
        public Testowy(int hades, int ostr, string szad, bool pork, float nullo)
        {
            this.przedmiot1 = hades;
            this.przedmiot2 = ostr;
            this.przedmiot3 = szad;
            this.przedmiot4 = pork;
            this.przedmiot5 = nullo;
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
            return przedmiot1 + " " + przedmiot3;
        }
        public bool Metoda3(long id)
        {
            return false;
        }
    }
    class MyClass
    {
        public void A(string name, int id)
        {
        }
        public void B(long id)
        {
        }
        public void C(string name, long id)
        {
        }
        public void D(long id2)
        {
        }
    }
    class Pusta
    {

    }
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Testowy t = new Testowy(1, 2, "tekst", false, 1.3f);

            int expected = 2;
            int actual = Program.CountMethods(t.GetType());

            Assert.AreEqual<int>(expected, actual);
        }
        [Fact]
        public void TestMethod2()
        {
            MyClass t = new MyClass();

            int expected = 2;
            int actual = Program.CountMethods(t.GetType());

            Assert.AreEqual<int>(expected, actual);
        }
        [Fact]
        public void TestMethod3()
        {
            Pusta t = new Pusta();

            int expected = 0;
            int actual = Program.CountMethods(t.GetType());
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
