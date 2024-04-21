using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_9_6_1_1
{
    public class MyException : Exception
    {
        public MyException()
        {

        }

        public MyException(string message) : base(message)
        {

        }
    }
}
