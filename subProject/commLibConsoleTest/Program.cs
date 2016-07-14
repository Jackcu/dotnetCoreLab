using commLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commLibConsoleTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

#if DEBUG
            Console.WriteLine(Dt.ToT1(DateTime.Now));
#endif


        }
    }
}
