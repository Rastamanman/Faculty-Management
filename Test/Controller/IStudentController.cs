﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Controller
{
    public interface IStudentController : IController
    {
        void AddOption(IOption op);
        IStudent GetStudent();
    }
}
