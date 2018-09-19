using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    interface IFaculty
    {
        List<IStudent> GetStudsFor(ISpecialization spec);
    }
}
