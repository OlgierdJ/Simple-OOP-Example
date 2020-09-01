using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5_Øvelse_1
{
    public class Assignment1
    {
        private int myVar;

        public int MyProperty
        {
            get => myVar; 
            set => myVar = value; 
        }

        public Assignment1(int i)
        {
            MyProperty = i;
        }

        public int IntFunction(dynamic s)
        {
            if (s.GetType() == typeof(int))
            {
                return myVar = s;
            }
            return 0;
        }
    }
}
