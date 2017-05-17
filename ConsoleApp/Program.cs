using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestClass(2,3);
            Reflection.MethodReflectorInfo<TestClass>(test);
        }
    }
}
