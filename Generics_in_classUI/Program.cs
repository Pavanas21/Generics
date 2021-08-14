using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_in_classUI
{
    class CompareClass
    {
        public bool Compare(string x, string y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
        public bool Compare(int x, int y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
    }
    class CompareGenericClass<T>
    {
        public bool Compare(T x, T y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CompareClass obj = new CompareClass();
            bool intresult = obj.Compare(5, 7);
            Console.WriteLine("int comapre result:" + intresult);
            bool stringresult = obj.Compare("Pavana", "Pavana");
            Console.WriteLine("string comapre result:" + stringresult);
            CompareGenericClass<string> Ocompare = new CompareGenericClass<string>();
            bool stringResult = Ocompare.Compare("Pavana", "Pavana");
            Console.WriteLine("Generic string comapre result:" + stringResult);
            CompareGenericClass<int> oIntcompare = new CompareGenericClass<int>();
            bool integerresult = oIntcompare.Compare(5, 6);
            Console.WriteLine("Generic int comapre result:" + integerresult);
        }
    }
}
