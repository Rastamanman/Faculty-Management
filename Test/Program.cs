using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Controller;
using Test.Models;
using Test.View;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IFacultyView mainView = new FacultyV();

            Faculty fac = new Faculty("Facultatea 51");
            Student stud = new Student("Alien", "Jupiterov", 3121212157899, null);
            Student stud2 = new Student("Domnul", "Annunaki", 4020202135445, null);
            fac.AddStudent(stud);
            fac.AddStudent(stud2);

            IFacultyController mainController = new FacultyController(mainView, fac);

            mainController.LoadView();
        }
    }
}
