using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Controller;

namespace Test.View
{
    public interface IFacultyView
    {
        void LoadView();
        void SetController(IFacultyController cont);
        void Enable();
        void Disable();
        void AddOp();
    }
}
