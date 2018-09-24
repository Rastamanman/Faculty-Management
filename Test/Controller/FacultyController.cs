using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.View;
using Test.Models;

namespace Test.Controller
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

        public void UpdateStudent(int index, IStudent stud)
        {
            faculta.UpdateStudent(index, stud);
        }
    }
}
