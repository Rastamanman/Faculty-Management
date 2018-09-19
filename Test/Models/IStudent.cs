using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    interface IStudent
    {
        void addOption(IOption option);
        void Admis(bool buget);
    }
}
