using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Option : IOption
    {
        private ISpecialization spec;
        private List<ITest> requirements;
        private int[] results;

        public Option(ISpecialization spec)
        {
            this.spec = spec;
            requirements = spec.GetTests();
            GenerateResults();
        }

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
    }
}
