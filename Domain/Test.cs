using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Domain
{
    public class TestClass
    {
        private double _d, _f;

        public TestClass(double d, double f)
        {
            _d = d;
            _f = f;
        }

        public double Sum()
        {
            return _d + _f;
        }

        public void Info()
        {
            Console.WriteLine(_d+_f);
        }

        public void Set (double d, double f)
        {
            _d = d;
            _f = f;
        }

        public override string ToString()
        {
            return "TestClass";
        }
    }

    public class Reflection
    {
        public static void MethodReflectorInfo<T>(T obj) 
            where T:class
        {
            Type t = typeof(T);
            MethodInfo[] methods = t.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
                ParameterInfo[] methodParameterInfos = method.GetParameters();
                for (int i = 0; i < methodParameterInfos.Length; i++)
                {
                    Console.WriteLine(methodParameterInfos[i].ParameterType.Name + methodParameterInfos[i].Name);
                }
            }
        }
    }
}
