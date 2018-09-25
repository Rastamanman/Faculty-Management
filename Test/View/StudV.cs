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
        OptionV opView;

        public StudV()
        {
            InitializeComponent();
        }

        private void StudV_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add Option from Option view.
        /// </summary>
        public void AddOp()
        {
            string[] row = opView.GetRow();
            row[0] = (optList.Items.Count + 1).ToString();
            optList.Items.Add(new ListViewItem(row));
        }

        public void LoadView()
        {

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
            List<IOption> optiuni = new List<IOption>();
            foreach(ListViewItem itm in optList.Items)
            {
                ISpecialization spec = controller.GetSpec(itm.SubItems[1].Text);
                bool buget = false;
                if (itm.SubItems[2].Text.ToUpper() == "BUGET")
                    buget = true;
                optiuni.Add(new Option(spec, buget));
            }
            controller.AddStudent(new Student(name, prenume, cnp, optiuni));
        }

        
        /// <summary>
        /// Add a new option to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOpB_Click(object sender, EventArgs e)
        {
            opView = new OptionV(this);
            IStudentController studentController = new StudentController(opView);
            opView.SetController(studentController);
            opView.Enable();
        }

        /// <summary>
        /// Remove the selected option from the option list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remOpB_Click(object sender, EventArgs e)
        {
            optList.Items.Remove(optList.SelectedItems[0]);
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
