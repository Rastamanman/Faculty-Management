using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Student : IStudent
    {
        private int index;
        private string nume;
        private string prenume;
        private long cnp;
        private List<IOption> optiuni;
        private bool admis;
        private bool buget;

        public Student(string n, string pren, long c, List<IOption> opt)
        {
            nume = n;
            prenume = pren;
            cnp = c;
            optiuni = opt;
            admis = false;
            buget = false;
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
            option.Index = optiuni.Count + 1;
            optiuni.Add(option);
        }

        /// <summary>
        /// Setter for admis.
        /// </summary>
        /// <param name="buget"></param>
        public void Admis(bool buget = false)
        {
            admis = true;
            this.buget = buget;
        }

        /// <summary>
        /// Returns true if the student attend the specialization.
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public bool AttendAtSpec(ISpecialization spec)
        {
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

        public void ClearOptions()
        {
            optiuni.Clear();
        }
    }
}
