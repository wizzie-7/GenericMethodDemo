using System;
using System.Collections.Generic;

namespace GenericMethodDemo
{
    class MethodGeneric
    {
        public void GenMethod()
        {
            List<string> LT = new List<string>();
            LT.Add("Vivek");
            LT.Add("Krunal");
            LT.Add("Nirbhay");
            LT.Add("Abhi");
            ProssedItem<string>(LT);
        }
        public void ProssedItem<T>(List<T> lst)
        {
            foreach (T Item in lst)
            {
                Console.WriteLine(Item);
            }

        }
    }
    class GnericMethodEx
    {
        static void Main(string[] args)
        {
            MethodGeneric mg = new MethodGeneric();
            mg.GenMethod();
        }
    }
}
