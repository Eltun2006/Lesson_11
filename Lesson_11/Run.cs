using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class Run
    {
        public void runFunc(Func arg, string arr)
        {
            if(arg != null)
                { arg(arr); }

        }
    }
}
