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
    public partial class FacultyV : Form, IFacultyView
    {
        private IFacultyController controller;
        OptionV opView;

        public FacultyV()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setter for the controller.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IFacultyController cont)
        {
            controller = cont;
        }

        /// <summary>
        /// Basic loader for the view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadSpecs();
        }


        /// <summary>
        /// Another Loader for the view.
        /// </summary>
        public void LoadView()
        {
            LoadStudents();
            LoadSpecs();
        }

        /// <summary>
        /// Load specializations list.
        /// </summary>
        public void LoadSpecs()
        {
            specList.Items.Clear();
            List<ISpecialization> specL = controller.GetSpecs();
            if(specL.Count != 0)
                foreach(Specialization spec in specL)
                {
                    string[] row = { spec.Index.ToString(), spec.Nume };
                    specList.Items.Add(new ListViewItem(row));
                }
        }

        /// <summary>
        /// Load the students into the list.
        /// </summary>
        public void LoadStudents()
        {
            studentsList.Items.Clear();
            List<IStudent> studList = controller.GetAllStudents();
            if(studList.Count != 0)
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
            LoadStudInfo(studToView);
            
        }

        /// <summary>
        /// Loads the student's info to the view.
        /// </summary>
        /// <param name="studToView"></param>
        public void LoadStudInfo(IStudent studToView)
        {
            index.Text = studToView.Index.ToString();
            nume.Text = studToView.Nume;
            prenume.Text = studToView.Prenume;
            cnp.Text = studToView.CNP.ToString();
            status.Text = studToView.Status();
            List<IOption> optiuni = studToView.Optiuni();
            if (optiuni != null)
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
            IFacultyView studV = new StudV(this);
            studV.SetController(controller);
            studV.Enable();
        }

        /// <summary>
        /// Open the Add new option for the viewed student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOptionB_Click(object sender, EventArgs e)
        {
            opView = new OptionV(this);
            opView.Enable();
        }

        /// <summary>
        /// Add the new option to the list and update the student.
        /// </summary>
        public void AddOp()
        {
            string[] row = opView.GetRow();
            if (optiuniList.Items.Count == 0)
                row[0] = "1";
            else
                row[0] = optiuniList.Items.Count + 1 + "";
            optiuniList.Items.Add(new ListViewItem(row));
            UpdateStudent(Int32.Parse(index.Text));
        }

        /// <summary>
        /// Update the current student.
        /// </summary>
        /// <param name="index"></param>
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
            stud.Index = index;
            controller.UpdateStudent(stud);
        }
        
        /// <summary>
        /// Remove a option from the student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeOptionB_Click(object sender, EventArgs e)
        {
            if (optiuniList.SelectedItems.Count == 0)
                return;
            optiuniList.Items.Remove(optiuniList.SelectedItems[0]);
            UpdateStudent(Int32.Parse(index.Text));
        }

        /// <summary>
        /// Add a new specialization button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSpecB_Click(object sender, EventArgs e)
        {
            SpecVcs newSpecView = new SpecVcs(controller.GetFac(), this);
            newSpecView.Enable();
        }

        /// <summary>
        /// View detailed info for the selected specialization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewSpecB_Click(object sender, EventArgs e)
        {
            if (specList.SelectedItems.Count == 0)
                return;
            int index = Int32.Parse(specList.SelectedItems[0].SubItems[0].Text);
            ISpecialization spec = controller.GetSpecById(index);
            LoadSpecInfo(spec);
            
        }

        /// <summary>
        /// Load specialization info.
        /// </summary>
        /// <param name="spec"></param>
        public void LoadSpecInfo(ISpecialization spec)
        {
            specID.Text = spec.Index.ToString();
            specName.Text = spec.Nume;
            specSize.Text = spec.Locuri.ToString();
            specTaxSize.Text = spec.LocuriTaxa.ToString();
            specBugSize.Text = (spec.Locuri - spec.LocuriTaxa).ToString();
            testsList.Items.Clear();
            List<ITest> tests = controller.GetTests(spec.Index);
            if (tests != null)
                foreach (Proiect.Models.Test t in tests)
                {
                    string[] row = { (testsList.Items.Count + 1).ToString(), t.Nume, t.Req.ToString(), t.Pondere.ToString() };
                    testsList.Items.Add(new ListViewItem(row));
                }

            LoadCandidati();
        }

        /// <summary>
        /// Remove selected specialization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remSpecB_Click(object sender, EventArgs e)
        {
            if (specList.SelectedItems.Count == 0)
                return;
            int remSpecId = Int32.Parse(specList.SelectedItems[0].SubItems[0].Text);
            specList.Items.Remove(specList.SelectedItems[0]);
            controller.RemoveSpec(remSpecId);
        }

        /// <summary>
        /// Load the list of the candidates.
        /// </summary>
        private void LoadCandidati()
        {
            candList.Items.Clear();
            scandidati.Text = "Lista Candidati:";
            if (specID.Text == ".")
                return;
            List<IStudent> studs = controller.GetStudsFor(Int32.Parse(specID.Text));
            if(studs.Count != 0)
                foreach(Student stud in studs)
                {
                    string[] row = { stud.Index.ToString(), stud.Nume, stud.Prenume };
                    candList.Items.Add(new ListViewItem(row));
                }
        }

        private void LoadAdmisi()
        {

        }

        /// <summary>
        /// Remove selected test from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remTestB_Click(object sender, EventArgs e)
        {
            if (testsList.SelectedItems.Count == 0)
                return;
            int testIndex = Int32.Parse(testsList.SelectedItems[0].SubItems[0].Text);
            int specIndex = Int32.Parse(specID.Text);
            testsList.Items.Remove(testsList.SelectedItems[0]);
        }

        /// <summary>
        /// Update specialization button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTestsB_Click(object sender, EventArgs e)
        {
            UpdateSpec();
        }

        /// <summary>
        /// Actually updating function for specialization.
        /// </summary>
        private void UpdateSpec()
        {
            if (specID.Text == ".")
                return;
            int indexOfSpec = Int32.Parse(specID.Text);
            ISpecialization spec = controller.GetSpecById(indexOfSpec);
            spec.ClearTests();
            foreach(ListViewItem itm in testsList.Items)
            {
                ITest testToAdd = new Proiect.Models.Test(itm.SubItems[1].Text, Int32.Parse(itm.SubItems[3].Text), Int32.Parse(itm.SubItems[2].Text));
                testToAdd.Index = Int32.Parse(itm.SubItems[0].Text);
                spec.AddTest(testToAdd);
            }
            spec.Locuri = Int32.Parse(specSize.Text);
            spec.LocuriTaxa = Int32.Parse(specTaxSize.Text);
            spec.Nume = specName.Text;

            controller.UpdateSpec(spec);
        }

        /// <summary>
        /// Load candidates in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seeCandB_Click(object sender, EventArgs e)
        {
            LoadCandidati();
        }

        /// <summary>
        /// Add a new specialization.
        /// </summary>
        /// <param name="newSpec"></param>
        public void AddNewSpec(ISpecialization newSpec)
        {
            controller.AddSpec(newSpec);
            LoadSpecs();
            LoadSpecInfo(newSpec);
        }

        /// <summary>
        /// Add a new Test to the tests list.
        /// </summary>
        /// <param name="newTest"></param>
        public void AddNewTest(ITest newTest)
        {
            string[] row = { testsList.Items.Count + 1 + "", newTest.Nume, newTest.Req.ToString(), newTest.Pondere.ToString() };
            testsList.Items.Add(new ListViewItem(row));
        }

        /// <summary>
        /// Add new test button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTestB_Click(object sender, EventArgs e)
        {
            TestV newTest = new TestV(this);
            newTest.Enable();
        }

        /// <summary>
        /// Determine if the faculty have a specific specialization.
        /// </summary>
        /// <param name="specName"></param>
        /// <returns></returns>
        public bool HaveSpec(string specName)
        {
            return controller.HaveSpec(specName);
        }

        /// <summary>
        /// Add a new student.
        /// </summary>
        /// <param name="stud"></param>
        public void AddStudent(IStudent stud)
        {
            controller.AddStudent(stud);
            LoadStudInfo(stud);
        }
    }
}
