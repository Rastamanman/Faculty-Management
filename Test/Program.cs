using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Controller;
using Proiect.Models;
using Proiect.View;

namespace Proiect
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
            Student stud = new Student("Alien", "Jupiterov", 3121212157899, "Masc", null);
            Student stud2 = new Student("Domnul", "Annunaki", 4020202135445, "Masc", null);
            
            
            Test test1 = new Test("Examen", 30, 5);
            Test test2 = new Test("Nota Bac", 70);
            List<ITest> teste = new List<ITest>();
            teste.Add(test1);
            teste.Add(test2);
            Specialization spec1 = new Specialization("Laser Tek", fac, 30, 20, teste);
            spec1.AddOption(new Option(spec1, true));
            spec1.AddOption(new Option(spec1, false));
            teste = new List<ITest>();
            test2 = new Test("Nota Bac", 100);
            teste.Add(test2);
            Specialization spec2 = new Specialization("Aero Dinamics", fac, 15, 5, teste);
            fac.AddSpec(spec1);
            fac.AddSpec(spec2);
            stud2.Admis(spec2, true);
            fac.AddStudent(stud);
            fac.AddStudent(stud2);

            IFacultyController mainController = new FacultyController(mainView, fac);

            mainController.LoadView();
        }
    }
}
