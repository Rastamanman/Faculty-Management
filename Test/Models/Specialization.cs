using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    class Specialization : ISpecialization
    {
        private string name;
        private int index;
        private int locuri;
        private int locuriTaxa;
        private List<ITest> teste;
        private List<IStudent> candidati;
        private List<IStudent> admisi;
        private IFaculty facultate;

        public Specialization(string n,IFaculty fac, int loc = 20, int locTax = 10, List<ITest> t = null, List<IStudent> cand = null)
        {
            name = n;
            if (t == null)
                teste = new List<ITest>();
            else
                teste = t;
            locuri = loc;
            teste = t;
            candidati = cand;
            locuriTaxa = locTax;
            facultate = fac;
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
        /// Get/Set for name.
        /// </summary>
        public string Nume
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Get/Set for number of positions.
        /// </summary>
        public int Locuri
        {
            get { return locuri; }
            set { locuri = value; }
        }
        
        /// <summary>
        /// Get/Set for number of position with tax.
        /// </summary>
        public int LocuriTaxa
        {
            get { return locuriTaxa; }
            set { locuriTaxa = value; }
        }

        public void sortCanditati()
        {
            //tobedone
        }

        /// <summary>
        /// Getter for tests.
        /// </summary>
        /// <returns></returns>
        public List<ITest> GetTests()
        {
            return teste;
        }

        /// <summary>
        /// Adds a new test.
        /// </summary>
        /// <param name="testToAdd"></param>
        public void AddTest(ITest testToAdd)
        {
            if (teste.Count == 0)
                testToAdd.Index = 1;
            else
                testToAdd.Index = teste.Last().Index + 1;
            teste.Add(testToAdd);
        }

        /// <summary>
        /// Remove a test by index.
        /// </summary>
        /// <param name="testIndex"></param>
        public void RemoveTest(int testIndex)
        {
            for(int it = 0; it < teste.Count; it++)
            {
                if (teste[it].Index == testIndex)
                {
                    teste.Remove(teste[it]);
                    return;
                }
            }
        }
        
        /// <summary>
        /// Clear tests object.
        /// </summary>
        public void ClearTests()
        {
            if(teste != null)
                teste.Clear();
        }
    }
}
