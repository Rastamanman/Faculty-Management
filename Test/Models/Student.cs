using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    class Student : IStudent
    {
        private int index;
        private string nume;
        private string prenume;
        private long cnp;
        private string sex;
        private List<IOption> optiuni;
        private bool admis;
        private bool buget;
        private ISpecialization enrolledSpec;

        public Student(string n, string pren, long c, string s, List<IOption> opt = null, ISpecialization enrolled = null)
        {
            nume = n;
            prenume = pren;
            cnp = c;
            sex = s;
            if (opt != null)
                optiuni = opt;
            else
                optiuni = new List<IOption>();
            admis = false;
            buget = false;
            if (enrolled != null)
                enrolledSpec = enrolled;
            else
                enrolledSpec = null;
        }

        /// <summary>
        /// Get/Set for nume.
        /// </summary>
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        /// <summary>
        /// Get/Set for index.
        /// </summary>
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        /// <summary>
        /// Get/Set for prenume.
        /// </summary>
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        /// <summary>
        /// Get/Set for cnp.
        /// </summary>
        public long CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }

        /// <summary>
        /// Getter for status.
        /// </summary>
        /// <returns></returns>
        public string Status()
        {
            if (admis == true)
                return "Intrat";
            return "Neintrat";
        }

        /// <summary>
        /// Add a new option for the student.
        /// </summary>
        /// <param name="option"></param>
        public void addOption(IOption option)
        {
            if (optiuni.Count == 0)
                option.Index = 1;
            else
                option.Index = optiuni.Last().Index + 1;
            optiuni.Add(option);
        }

        /// <summary>
        /// Setter for admis.
        /// </summary>
        /// <param name="buget"></param>
        public void Admis(ISpecialization admSpec, bool buget = false)
        {
            admis = true;
            enrolledSpec = admSpec;
            this.buget = buget;
        }

        /// <summary>
        /// Returns true if the student attend the specialization.
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public bool AttendAtSpec(ISpecialization spec)
        {
            if (optiuni.Count == 0)
                return false;
            foreach(Option opt in optiuni)
            {
                if (opt.HaveSpec(spec) == true)
                    return true;
            }
            return false;
        }
        
        /// <summary>
        /// Oveerride of ToString for Nume + Prenume.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nume + " " + prenume;
        }

        /// <summary>
        /// Get a list of the options.
        /// </summary>
        /// <returns></returns>
        public List<IOption> Optiuni()
        {
            return optiuni;
        }

        /// <summary>
        /// Clear options data.
        /// </summary>
        public void ClearOptions()
        {
            if (optiuni.Count == 0)
                return;
            optiuni.Clear();
        }

        /// <summary>
        /// Update options for latest tests.
        /// </summary>
        public void UpdateOptions()
        {
            foreach(IOption op in optiuni)
            {
                op.Update();
            }
        }

        /// <summary>
        /// Get/Set for enroledSpec
        /// </summary>
        public ISpecialization EnrolledSpec
        {
            get { return enrolledSpec; }
            set { enrolledSpec = value; }
        }

        /// <summary>
        /// Get/Set for gender.
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

    }
}
