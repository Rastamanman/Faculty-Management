using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Models;
using Proiect.Controller;


namespace Proiect.View
{
    public partial class SpecVcs : Form, IView
    {
        IController cont;
        ISpecialization spec;
        IFaculty fac;
        FacultyV dest;

        public SpecVcs(IFaculty fac, FacultyV dest)
        {
            this.fac = fac;
            this.dest = dest;
            InitializeComponent();
        }

        /// <summary>
        /// Setter for controller.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IController cont)
        {
            this.cont = cont;
        }

        public void LoadView()
        {
            SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            this.Enable();
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

        private void SpecVcs_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load spec object from view data.
        /// </summary>
        public void LoadSpec()
        {
            spec = new Specialization(name.Text, fac, Int32.Parse(loc.Text), Int32.Parse(locTax.Text));
        }

        /// <summary>
        /// Getter for spec object.
        /// </summary>
        /// <returns></returns>
        public ISpecialization GetSpec()
        {
            return spec;
        }

        /// <summary>
        /// Add specialization button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSpecB_Click(object sender, EventArgs e)
        {
            LoadSpec();
            dest.AddNewSpec(spec);
            this.Disable();
        }

        /// <summary>
        /// Cancel button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Disable();
        }
    }
}
