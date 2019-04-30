using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;


namespace _005_Yield
{
    class UserCollection
    {

        public static IEnumerable Power()
        {
            while (true)
                yield return "Hello world!";
        }
    }
}
