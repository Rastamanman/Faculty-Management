using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;

namespace Proiect.Controller
{
    public interface IStudentController : IController
    {
        void AddOption(IOption op);
        IStudent GetStudent();
    }
}
