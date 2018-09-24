using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Faculty : IFaculty
    {

        string name;
        List<ISpecialization> specs;
        List<IStudent> students;

        public Faculty(string name = "Default")
        {
            this.name = name;
            specs = new List<ISpecialization>();
            students = new List<IStudent>();
        }

        /// <summary>
        /// Get all the students for a specific specialization.
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public List<IStudent> GetStudsFor(ISpecialization spec)
        {
            List<IStudent> returnedList = new List<IStudent>();
            foreach(Student stud in students)
            {
                if (stud.AttendAtSpec(spec))
                    returnedList.Add(stud);
            }
            return returnedList;
        }

        /// <summary>
        /// Get a list of all students.
        /// </summary>
        /// <returns></returns>
        public List<IStudent> GetAllStudents()
        {
            return students;
        }

        /// <summary>
        /// Add a new student.
        /// </summary>
        /// <param name="stud"></param>
        public void AddStudent(IStudent stud)
        {
            stud.Index = students.Count + 1;
            students.Add(stud);
        }

        /// <summary>
        /// Get a student by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IStudent GetStudById(int id)
        {
            foreach(Student stud in students)
            {
                if (stud.Index == id)
                    return stud;
            }
            return null;
        }

        /// <summary>
        /// Remove a student by ID.
        /// </summary>
        /// <param name="id"></param>
        public void RemoveStudent(int id)
        {
            bool updateID = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (updateID)
                    students[i].Index -= 1;
                else if (students[i].Index == id)
                {
                    students.Remove(students[i]);
                    updateID = true;
                    i--;
                }
            }
        }

        /// <summary>
        /// Get specialization by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ISpecialization GetSpec(string name)
        {
            foreach(Specialization spec in specs)
            {
                if (name.ToUpper() == spec.Nume.ToUpper())
                    return spec;
            }
            return null;
        }

        public void UpdateStudent(int index, IStudent stud)
        {
            for(int i = 0; i < students.Count; i++)
            {
                if(students[i].Index == index)
                {
                    students[i] = stud;
                    return;
                }
            }
        }
    }
}
