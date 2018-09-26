using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public interface IFaculty
    {
        List<IStudent> GetAllStudents();
        IStudent GetStudById(int id);
        void RemoveStudent(int id);
        void AddStudent(IStudent stud);
        ISpecialization GetSpec(string name);
        void UpdateStudent(IStudent stud);
        List<ISpecialization> GetSpecs();
        void RemoveSpec(int index);
        ISpecialization GetSpecById(int index);
        List<ITest> GetTests(int index);
        List<IStudent> GetStudsFor(int index);
        void AddSpec(ISpecialization specToAdd);
        void RemoveTest(int specIndex, int testIndex);
        void UpdateSpec(ISpecialization spec);
        bool HaveSpec(string specName);
        int GetIndexForStud();
    }
}
