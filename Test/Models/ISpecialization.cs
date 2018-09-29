using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public interface ISpecialization
    {
        List<ITest> GetTests();
        void sortCanditati();
        string Nume { get; set; }
        int Locuri { get; set; }
        int Index { get; set; }
        int LocuriTaxa { get; set; }
        void AddTest(ITest testToAdd);
        void RemoveTest(int testIndex);
        void ClearTests();
        void AddOption(IOption opToAdd);
        void RemoveOption(IOption opToRemove);
    }
}
