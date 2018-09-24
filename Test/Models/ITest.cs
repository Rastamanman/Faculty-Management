using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public interface ITest
    {
        bool passed(int value);
        int Pondere { get; set; }
    }
}
