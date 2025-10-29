using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyUnitTests
{
    public class DummyFunction
    {
        public string ReturnsHelloWorldIfZero(int num)
        {
            if (num != 0)
            {
                return "Not Zero!";
            }
            return "Hello, World!";
        }
    }
}
