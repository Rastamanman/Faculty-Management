using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;

namespace Proiect.Models
{
    public interface IStudent
    {
        void addOption(IOption option);
        void Admis(ISpecialization admSpec, bool buget);
        bool AttendAtSpec(ISpecialization spec);
        string Nume { get; set; }
        string Prenume { get; set; }
        long CNP { get; set; }
        int Index { get; set; }
        string Status();
        List<IOption> Optiuni();
        void ClearOptions();
        void UpdateOptions();
        ISpecialization EnrolledSpec { get; set; }
        string Sex { get; set; }
    }
}
