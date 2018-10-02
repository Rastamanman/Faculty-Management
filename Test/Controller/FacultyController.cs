using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.View;
using Proiect.Models;

namespace Proiect.Controller
{
    class FacultyController : IFacultyController
    {
        private IFacultyView view;
        private IFaculty faculta;

        public FacultyController(IFacultyView v, IFaculty fac)
        {
            faculta = fac;
            view = v;
            v.SetController(this);
        }

        /// <summary>
        /// Load controller's view.
        /// </summary>
        public void LoadView()
        {
            view.Enable();
        }

        /// <summary>
        /// Get a list of all students.
        /// </summary>
        /// <returns>A list of all students.</returns>
        public List<IStudent> GetAllStudents()
        {
            return faculta.GetAllStudents();
        }

        /// <summary>
        /// Get a student by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A student with a specific ID.</returns>
        public IStudent GetStudById(int id)
        {
            return faculta.GetStudById(id);
        }

        /// <summary>
        /// Remove a student by ID.
        /// </summary>
        /// <param name="id"></param>
        public void RemoveStudent(int id)
        {
            faculta.RemoveStudent(id);
        }

        /// <summary>
        /// Add a new student.
        /// </summary>
        /// <param name="stud"></param>
        public void AddStudent(IStudent stud)
        {
            faculta.AddStudent(stud);
            view.LoadView();
        }

        /// <summary>
        /// Get a specialization by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>A specialization searched by a specific name.</returns>
        public ISpecialization GetSpec(string name)
        {
            return faculta.GetSpec(name);
        }

        /// <summary>
        /// Update a student.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="stud"></param>
        public void UpdateStudent(IStudent stud)
        {
            faculta.UpdateStudent(stud);
        }

        /// <summary>
        /// Get all specializations.
        /// </summary>
        /// <returns></returns>
        public List<ISpecialization> GetSpecs()
        {
            return faculta.GetSpecs();
        }

        /// <summary>
        /// Remove a specialization by index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveSpec(int index)
        {
            faculta.RemoveSpec(index);
        }

        /// <summary>
        /// Get a specialization by id/index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ISpecialization GetSpecById(int index)
        {
            return faculta.GetSpecById(index);
        }

        /// <summary>
        /// Get tests for a specialization by index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<ITest> GetTests(int index)
        {
            return faculta.GetTests(index);
        }

        /// <summary>
        /// Get students for a specialization by index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<IStudent> GetStudsFor(int index)
        {
            return faculta.GetStudsFor(index);
        }

        /// <summary>
        /// Remove a test from a specialization by indexes.
        /// </summary>
        /// <param name="specIndex"></param>
        /// <param name="testIndex"></param>
        public void RemoveTest(int specIndex, int testIndex)
        {
            faculta.RemoveTest(specIndex, testIndex);
        }

        /// <summary>
        /// Updates a specialization.
        /// </summary>
        /// <param name="spec"></param>
        public void UpdateSpec(ISpecialization spec)
        {
            faculta.UpdateSpec(spec);
        }

        /// <summary>
        /// Add a specialization.
        /// </summary>
        /// <param name="newSpec"></param>
        public void AddSpec(ISpecialization newSpec)
        {
            faculta.AddSpec(newSpec);
        }

        /// <summary>
        /// Getter for faculty object.
        /// </summary>
        /// <returns></returns>
        public IFaculty GetFac()
        {
            return faculta;
        }

        /// <summary>
        /// Determine if the faculty object have a specialization by name.
        /// </summary>
        /// <param name="specName"></param>
        /// <returns></returns>
        public bool HaveSpec(string specName)
        {
            return faculta.HaveSpec(specName);
        }

        /// <summary>
        /// Computes the next index/ID for a new student.
        /// </summary>
        /// <returns></returns>
        public int GetIndexForStud()
        {
            return faculta.GetIndexForStud();
        }

        public List<IStudent> GetStudentsFor(ISpecialization spec)
        {
            return faculta.GetStudentsFor(spec);
        }

        public List<IOption> GetOptions()
        {
            return faculta.GetOptions();
        }
        
        public IOption GetOption(string name)
        {
            return faculta.GetOption(name);
        }
    }
}
