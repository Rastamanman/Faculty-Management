using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Test.View;

namespace Test.Controller
{
    class StudentController : IStudentController
    {
        IStudentView view;
        IStudent stud;
    
        public StudentController(IStudentView vw, IStudent st = null)
        {
            view = vw;
            stud = st;
        }

        public void AddOption(IOption op)
        {
            stud.addOption(op);
        }

        public IStudent GetStudent()
        {
            return stud;
        }
    }
}
