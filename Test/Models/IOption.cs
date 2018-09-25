using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public interface IOption
    {
        bool checkIfPassed();
        void GenerateResults();
        bool HaveSpec(ISpecialization spec);
        string Nume { get; }
        int Index { get; set; }
        string Tip { get; }
    }
}
