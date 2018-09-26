using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;

namespace Proiect.Controller
{
    public interface IFacultyController : IController
    {
        void LoadView();
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
        void RemoveTest(int specIndex, int testIndex);
        void UpdateSpec(ISpecialization spec);
        void AddSpec(ISpecialization newSpec);
        IFaculty GetFac();
        bool HaveSpec(string specName);
        int GetIndexForStud();
    }
}
