using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    interface ISpecialization
    {
        List<ITest> GetTests();
        void sortCanditati();
    }
}
