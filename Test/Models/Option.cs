using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    class Option : IOption
    {
        private int index;
        private ISpecialization spec;
        private bool buget;
        private List<ITest> requirements;
        private int[] results;

        public Option(ISpecialization spec, bool buget)
        {
            this.spec = spec;
            this.buget = buget;
            Update();
            GenerateResults();
        }

        /// <summary>
        /// Update Option's tests.
        /// </summary>
        public void Update()
        {
            requirements = spec.GetTests();
            results = new int[requirements.Count];
        }

        /// <summary>
        /// Getter for specialization's name.
        /// </summary>
        public string Nume
        {
            get { return spec.Nume; }
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
        /// Getter for option's type.
        /// </summary>
        public string Tip
        {
            get { if (buget) return "Buget"; else return "Taxa"; }
        }

        /// <summary>
        /// Return true if the student passed the exams.
        /// </summary>
        /// <returns></returns>
        public bool checkIfPassed()
        {
            int iterator = 0;
            bool passed = true;
            foreach(ITest test in requirements)
            {
                passed = passed && test.passed(results[iterator]);
                iterator++;
            }
            return passed;
        }

        /// <summary>
        /// Generate random results for option's tests.
        /// </summary>
        public void GenerateResults()
        {
            Random rnd = new Random();
            int iterator = 0;
            foreach (ITest test in requirements)
            {
                results[iterator] = rnd.Next(10) + 1;
                iterator++;
            }
        }

        /// <summary>
        /// Returns true if this option attend to a specific specialization.
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public bool HaveSpec(ISpecialization spec)
        {
            if (this.spec == spec)
                return true;
            return false;
        }

        /// <summary>
        /// Override for ToString to Spec name + type.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string toReturn = spec.Nume + " - ";
            if (buget == true)
                toReturn += "Buget";
            else
                toReturn += "Taxa";
            return toReturn;
        }

        /// <summary>
        /// Calculate the final grade for this option.
        /// </summary>
        /// <returns></returns>
        public double Nota()
        {
            float nota = 0;
            int pondereTotal = 0;

            for(int it = 0; it < requirements.Count; it++)
            {
                if(requirements[it].passed(results[it]))
                {
                    pondereTotal += requirements[it].Pondere;
                    nota += results[it] * requirements[it].Pondere / 100;
                }
            }
            return (nota * 100) / pondereTotal;
        }
    }
}
