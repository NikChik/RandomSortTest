using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Helpers
{
    public class Counter
    {
        private int _value;

        public int Value => _value;

        public Counter()
        {
            Reset();
        }

        public void Reset()
        {
            _value = 0;
        }

        public void Count()
        {
            _value++;
        }
    }
}
