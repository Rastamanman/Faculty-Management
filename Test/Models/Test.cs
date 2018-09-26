using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    class Test : ITest
    {
        int index;
        string denumire;
        int req;
        int pondere;

        public Test(string d, int p, int r = 0)
        {
            denumire = d;
            req = r;
            pondere = p;
        }

        /// <summary>
        /// Get/Set for index;
        /// </summary>
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        /// <summary>
        /// Get/Set for name.
        /// </summary>
        public string Nume
        {
            get { return denumire; }
            set { denumire = value; }
        }

        /// <summary>
        /// Get/Set for requirement grade.
        /// </summary>
        public int Req
        {
            get { return req; }
            set { req = value; }
        }

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
