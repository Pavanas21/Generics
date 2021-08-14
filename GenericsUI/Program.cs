using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GenericsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compare Integer  
            Check<int> obj1 = new Check<int>();
            bool intResult = obj1.Compare(2, 3);
            // Compare String  
            Check<string> obj2 = new Check<string>();
            bool strResult = obj2.Compare("Ramakrishna", "Ramakrishna");
            Console.WriteLine("Integer Comparison: {0}\nString Comparison: {1}", intResult, strResult);
            Console.Read();
        }
        // Generic class to accept all types of data types  
        class Check<UnknowDataType>
        {
            // Gerefic function to compare all data types  
            public bool Compare(UnknowDataType var1, UnknowDataType var2)
            {
                if (var1.Equals(var2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}