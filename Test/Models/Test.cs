using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Test : ITest
    {
        string denumire;
        int req;
        int pondere;

        /// <summary>
        /// Whether or not the value(grade) passed the test.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool passed(int value)
        {
            return value >= req;
        }

        /// <summary>
        /// Get/Set for pondere.
        /// </summary>
        public int Pondere
        {
            get { return pondere; }
            set { pondere = value; }
        }
            
    }
}
