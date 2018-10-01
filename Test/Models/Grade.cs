using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    class Grade : IGrade
    {
        private double value;

        public double Nota
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}
