using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfDemo
{
    public class Compute : ICompute
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public class ComputeNew : ICompute
    {
        public int Add(int a, int b)
        {
            return 2 * (a + b);
        }

        public int Multiply(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }
}