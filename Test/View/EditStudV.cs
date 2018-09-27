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
    public partial class EditStudV : Form, IView
    {
        IController cont;
        IStudent stud;
        FacultyV dest;

        public EditStudV(IStudent stud, FacultyV dest)
        {
            InitializeComponent();
            this.stud = stud;
            this.dest = dest;
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
        /// Setter for the controller.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IController cont)
        {
            this.cont = cont;
        }

        /// <summary>
        /// Set view's data.
        /// </summary>
        public void SetInfo()
        {
            this.nume.Text = stud.Nume;
            this.prenume.Text = stud.Prenume;
            this.cnp.Text = stud.CNP.ToString();
            SetSex();
        }

        /// <summary>
        /// Set sex.
        /// </summary>
        public void SetSex()
        {
            if(stud.Sex.ToUpper() == "MASC")
            {
                mascOp.Checked = true;
                femOp.Checked = false;
            }
            else if(stud.Sex.ToUpper() == "FEM")
            {
                femOp.Checked = true;
                mascOp.Checked = false;
            }
            else
            {
                mascOp.Checked = false;
                femOp.Checked = false;
            }
        }

        /// <summary>
        /// Get sex to string.
        /// </summary>
        /// <returns></returns>
        public string GetSex()
        {
            if (mascOp.Checked == true)
                return "Masc";
            else if (femOp.Checked == true)
                return "Fem";
            else
                return "Not Specified";
        }

        /// <summary>
        /// Load the view.
        /// </summary>
        public void LoadView()
        {
            SetInfo();
            this.Enable();
        }

        /// <summary>
        /// Update student object from view's data.
        /// </summary>
        public void UpdateStud()
        {
            stud.Nume = nume.Text;
            stud.Prenume = prenume.Text;
            stud.CNP = long.Parse(cnp.Text);
            stud.Sex = GetSex();
        }

        /// <summary>
        /// Save button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveB_Click(object sender, EventArgs e)
        {
            UpdateStud();
            dest.UpdateStudent(stud);
            dest.LoadStudInfo(stud);
            Disable();
        }

        /// <summary>
        /// Cancel button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelB_Click(object sender, EventArgs e)
        {
            Disable();
        }
    }
}
