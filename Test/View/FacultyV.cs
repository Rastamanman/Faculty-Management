using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Controller;
using Test.Models;

namespace Test.View
{
    public partial class FacultyV : Form, IFacultyView
    {
        private IFacultyController controller;
        OptionV opView;

        public FacultyV()
        {
            InitializeComponent();
        }

        public void SetController(IFacultyController cont)
        {
            controller = cont;
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadView()
        {
            LoadStudents();
        }

        /// <summary>
        /// Load the students into the list.
        /// </summary>
        public void LoadStudents()
        {
            studentsList.Items.Clear();
            List<IStudent> studList = controller.GetAllStudents();
            foreach (Student stud in studList)
            {
                string[] row = { stud.Index.ToString(), stud.Nume, stud.Prenume };
                studentsList.Items.Add(new ListViewItem(row));
            }
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
        /// Load selected student's detail in view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewStudB_Click(object sender, EventArgs e)
        {
            if (studentsList.SelectedItems.Count == 0)
                return;
            int selectedID = Int32.Parse(studentsList.SelectedItems[0].SubItems[0].Text);
            IStudent studToView = controller.GetStudById(selectedID);

            index.Text = studToView.Index.ToString();
            nume.Text = studToView.Nume;
            prenume.Text = studToView.Prenume;
            cnp.Text = studToView.CNP.ToString();
            status.Text = studToView.Status();
            List<IOption> optiuni = studToView.Optiuni();
            if(optiuni != null)
                foreach (Option op in optiuni)
                {
                    string[] row = { op.Index.ToString(), op.Nume, op.Tip, op.Nota().ToString() };
                    optiuniList.Items.Add(new ListViewItem(row));
                }
        }

        /// <summary>
        /// Remove the selected student by it's id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remStudB_Click(object sender, EventArgs e)
        {
            if (studentsList.SelectedItems.Count == 0)
                return;
            int selectedID = Int32.Parse(studentsList.SelectedItems[0].SubItems[0].Text);
            controller.RemoveStudent(selectedID);
            LoadStudents();
        }

        /// <summary>
        /// Add a new student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addStudB_Click(object sender, EventArgs e)
        {
            IFacultyView studV = new StudV();
            studV.SetController(controller);
            studV.Enable();
        }

        private void addOptionB_Click(object sender, EventArgs e)
        {
            opView = new OptionV(this);
            IStudentController studentController = new StudentController(opView);
            opView.SetController(studentController);
            opView.Enable();
        }

        public void AddOp()
        {
            string[] row = opView.GetRow();
            optiuniList.Items.Add(new ListViewItem(row));
            //  ???     index.text nu e format bun pt string    ???
            UpdateStudent(Int32.Parse(index.Text));
        }

        public void UpdateStudent(int index)
        {
            IStudent stud = controller.GetStudById(index);
            stud.ClearOptions();
            foreach(ListViewItem itm in optiuniList.Items)
            {
                ISpecialization spec = controller.GetSpec(itm.SubItems[1].Text);
                bool buget = false;
                if (itm.SubItems[2].Text.ToUpper() == "BUGET")
                    buget = true;
                IOption op = new Option(spec, buget);
                stud.addOption(op);
            }
            controller.UpdateStudent(index, stud);
        }

        private void removeOptionB_Click(object sender, EventArgs e)
        {
            if (optiuniList.SelectedItems.Count == 0)
                return;
            optiuniList.Items.Remove(optiuniList.SelectedItems[0]);
            UpdateStudent(Int32.Parse(index.Text));
        }
    }
}
