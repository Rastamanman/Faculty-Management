using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Controller;

namespace Proiect.View
{
    interface IView
    {
        void LoadView();
        void SetController(IController cont);
        void Enable();
        void Disable();
    }
}
