using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Student : IStudent
    {
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

        public void addOption(IOption option)
        {
            optiuni.Add(option);
        }

        public void Admis(bool buget = false)
        {
            admis = true;
            this.buget = buget;
        }
    }
}
