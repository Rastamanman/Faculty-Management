﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.View;

namespace Proiect.Controller
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
