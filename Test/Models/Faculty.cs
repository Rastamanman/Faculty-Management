using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
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
        public List<IStudent> GetStudsFor(int index)
        {
            ISpecialization specificSpec = null;
            foreach (Specialization spec in specs)
            {
                if (spec.Index == index)
                {
                    specificSpec = spec;
                    break;
                }
            }
            
            List<IStudent> returnedList = new List<IStudent>();
            foreach(Student stud in students)
            {
                if (stud.AttendAtSpec(specificSpec))
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
            if (students.Count != 0)
                stud.Index = students.Last().Index + 1;
            else
                stud.Index = 1;
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
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Index == id)
                {
                    students.Remove(students[i]);
                    return;
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

        /// <summary>
        /// Update a specific student.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="stud"></param>
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

        /// <summary>
        /// Get all specializations.
        /// </summary>
        /// <returns></returns>
        public List<ISpecialization> GetSpecs()
        {
            return specs;
        }

        public void RemoveSpec(int index)
        {
            for(int it = 0; it < specs.Count; it++)
            {
                if(specs[it].Index == index)
                {
                    specs.Remove(specs[it]);
                    return;
                }
            }
        }

        public ISpecialization GetSpecById(int index)
        {
            foreach(Specialization spec in specs)
            {
                if (spec.Index == index)
                    return spec;
            }
            return null;
        }

        public List<ITest> GetTests(int index)
        {
            foreach(Specialization spec in specs)
            {
                if(spec.Index == index)
                {
                    return spec.GetTests();
                }
            }
            return null;
        }

        public void AddSpec(ISpecialization specToAdd)
        {
            if (specs.Count != 0)
                specToAdd.Index = specs.Last().Index + 1;
            else
                specToAdd.Index = 1;
            specs.Add(specToAdd);
        }

        public void RemoveTest(int specIndex, int testIndex)
        {
            foreach(Specialization spec in specs)
            {
                if(spec.Index == specIndex)
                {
                    spec.RemoveTest(testIndex);
                    return;
                }
            }
        }

        public void UpdateSpec(ISpecialization spec)
        {
            for(int it = 0; it < specs.Count; it++)
            {
                if(specs[it].Index == spec.Index)
                {
                    specs[it] = spec;
                    return;
                }
            }
        }
    }
}
