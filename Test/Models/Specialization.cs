using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Specialization : ISpecialization
    {
        private string name;
        private int locuri;
        private int locuriTaxa;
        private List<ITest> teste;
        private List<IStudent> candidati;
        private List<IStudent> admisi;
        private IFaculty facultate;

        public Specialization(string n,IFaculty fac, List<ITest> t = null, List<IStudent> cand = null, int loc = 20, int locTax = 10)
        {
            name = n;
            teste = t;
            locuri = loc;
            teste = t;
            candidati = cand;
            locuriTaxa = locTax;
            facultate = fac;
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

        public void sortCanditati()
        {
            //tobedone
        }

        public List<ITest> GetTests()
        {
            return teste;
        }
    }
}
