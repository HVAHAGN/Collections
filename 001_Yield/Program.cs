﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _001_Yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
                Console.WriteLine(element);

            Console.WriteLine(new string('-', 12));

            //-----------------------------------------------------------------------------------------------
            // Так работает foreach.

            IEnumerable enumerable = UserCollection.Power();

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext()) // Перемещаем курсор на 1 шаг вперед.
            {
                String element = enumerator.Current as String;

                Console.WriteLine(element);
            }

            // Delay. 
            Console.ReadKey();
        }
    }
}
