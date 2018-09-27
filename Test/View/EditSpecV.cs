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
    public partial class EditSpecV : Form, IView
    {
        IController cont;
        FacultyV dest;
        ISpecialization spec;

        public EditSpecV(ISpecialization spec, FacultyV dest)
        {
            this.dest = dest;
            this.spec = spec;
            InitializeComponent();
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
        /// Load the view.
        /// </summary>
        public void LoadView()
        {
            LoadInfo();
            this.Enable();
        }

        /// <summary>
        /// Load info from the object.
        /// </summary>
        public void LoadInfo()
        {
            nume.Text = spec.Nume;
            nrLoc.Text = spec.Locuri.ToString();
            nrLocTax.Text = spec.LocuriTaxa.ToString();
        }

        /// <summary>
        /// Update specialization object from view's data.
        /// </summary>
        public void UpdateSpec()
        {
            spec.Nume = nume.Text;
            spec.Locuri = Int32.Parse(nrLoc.Text);
            spec.LocuriTaxa = Int32.Parse(nrLocTax.Text);
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

        private void saveB_Click(object sender, EventArgs e)
        {
            UpdateSpec();
            dest.LoadSpecInfo(spec);
            dest.UpdateSpec(spec);
        }
    }
}
