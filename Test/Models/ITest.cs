using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public interface ITest
    {
        int Req { get; set; }
        string Nume { get; set; }
        bool passed(double value);
        int Pondere { get; set; }
        int Index { get; set; }
    }
}
