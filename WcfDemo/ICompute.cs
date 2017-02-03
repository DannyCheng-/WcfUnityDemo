using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfDemo
{
    public interface ICompute
    {
        int Add(int a, int b);

        int Multiply(int a, int b);
    }
}
