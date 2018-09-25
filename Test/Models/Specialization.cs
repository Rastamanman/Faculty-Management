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

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Nume
        {
            get { return name; }
            set { name = value; }
        }

        public int Locuri
        {
            get { return locuri; }
            set { locuri = value; }
        }
        
        public int LocuriTaxa
        {
            get { return locuriTaxa; }
            set { locuriTaxa = value; }
        }

        public void sortCanditati()
        {
            //tobedone
        }

        public List<ITest> GetTests()
        {
            return teste;
        }

        public void AddTest(ITest testToAdd)
        {
            if (teste.Count == 0)
                testToAdd.Index = 1;
            else
                testToAdd.Index = teste.Last().Index + 1;
            teste.Add(testToAdd);
        }

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

        public void ClearTests()
        {
            teste.Clear();
        }
    }
}
