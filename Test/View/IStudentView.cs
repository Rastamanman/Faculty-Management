using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Controller;

namespace Proiect.View
{
    interface IStudentView
    {
        void LoadView();
        void SetController(IStudentController cont);
        void Enable();
        void Disable();
    }
}
