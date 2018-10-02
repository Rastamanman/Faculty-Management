using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Controller;
using Proiect.Models;

namespace Proiect.View
{
    public partial class StudV : Form, IFacultyView
    {
        IFacultyController controller;
        FacultyV facV;

        public StudV(FacultyV facV)
        {
            this.facV = facV;
            InitializeComponent();
        }

        private void StudV_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load the view.
        /// </summary>
        public void LoadView()
        {
            SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            this.Enable();
        }

        /// <summary>
        /// Clear view data.
        /// </summary>
        public void ClearView()
        {
            tNume.Clear();
            tPrenume.Clear();
            tCnp.Clear();
        }

        /// <summary>
        /// Set the controller of the view.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IFacultyController cont)
        {
            controller = cont;
        }

        /// <summary>
        /// Enable the view.
        /// </summary>
        public void Enable()
        {
            this.Visible = false;
            this.ShowDialog();
        }

        /// <summary>
        /// Disable the view.
        /// </summary>
        public void Disable()
        {
            this.Visible = false;
            this.Enabled = false;
        }

        /// <summary>
        /// Return true if there are errors int input.
        /// </summary>
        /// <returns></returns>
        public bool checkForErrors()
        {
            if (tNume.Text == "" || tPrenume.Text == "" || tCnp.Text == "")
                return true;
            return false;
        }

        /// <summary>
        /// Add the new student to the faculty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAndAdd_Click(object sender, EventArgs e)
        {
            if(checkForErrors())
            {
                //error
                return;
            }
            string name = tNume.Text;
            string prenume = tPrenume.Text;
            long cnp = long.Parse(tCnp.Text);
            string sex;
            if (mascOpt.Checked == true)
                sex = "Masc";
            else if (femOpt.Checked == true)
                sex = "Fem";
            else
                sex = "Not Specified";
            List<IOption> optiuni = new List<IOption>();
            IStudent studToAdd = new Student(name, prenume, cnp, sex, optiuni);
            studToAdd.Index = controller.GetIndexForStud();
            facV.AddStudent(studToAdd);
            ClearView();
        }

        /// <summary>
        /// Cancel the request.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Disable();
        }
    }
}
