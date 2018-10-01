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
        /// Clears student info data.
        /// </summary>
        public void ClearStudentInfo()
        {
            index.Text = ".";
            nume.Text = ".";
            prenume.Text = ".";
            cnp.Text = ".";
            sex.Text = ".";
            optiuniList.Items.Clear();
        }

        /// <summary>
        /// Clears speciazliation info data.
        /// </summary>
        public void ClearSpecInfo()
        {
            specID.Text = ".";
            specName.Text = ".";
            specSize.Text = ".";
            specTaxSize.Text = ".";
            specBugSize.Text = ".";
            enrolledSpec.Text = ".";
            testsList.Items.Clear();
            candList.Items.Clear();
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
                    specBox.Items.Add(spec.ToString());
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
            ClearStudentInfo();
            index.Text = studToView.Index.ToString();
            nume.Text = studToView.Nume;
            prenume.Text = studToView.Prenume;
            cnp.Text = studToView.CNP.ToString();
            sex.Text = studToView.Sex;
            status.Text = studToView.Status();
            if (status.Text.ToUpper() == "INTRAT")
                enrolledSpec.Text = studToView.EnrolledSpec.Nume + " - " + studToView.BugetToString();
            else
                enrolledSpec.Text = "";
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
            studV.LoadView();
        }

        /// <summary>
        /// Open the Add new option for the viewed student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOptionB_Click(object sender, EventArgs e)
        {
            if (index.Text == ".")
                return;
            OptionV opView = new OptionV(this);
            opView.LoadView();
        }

        /// <summary>
        /// Add the new option to the list and update the student.
        /// </summary>
        public void AddOp(OptionV opView)
        {
            string[] row = opView.GetRow();
            if (optiuniList.Items.Count == 0)
                row[0] = "1";
            else
                row[0] = optiuniList.Items.Count + 1 + "";
            foreach(ListViewItem itm in optiuniList.Items)
            {
                if (itm.SubItems[1].Text.ToUpper() == row[1].ToUpper() && itm.SubItems[2].Text.ToUpper() == row[2].ToUpper())
                {
                    MessageBox.Show("Option already exist!", "Option Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            optiuniList.Items.Add(new ListViewItem(row));
        }

        /// <summary>
        /// Update the current student.
        /// </summary>
        /// <param name="index"></param>
        public void UpdateStudent(IStudent stud)
        {
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
            if (specBox.Items.Count == 0)
                return;
            ISpecialization spec = controller.GetSpec(specBox.SelectedItem.ToString());
            List<IStudent> studs = controller.GetStudentsFor(spec);
            if(studs.Count != 0)
                foreach(Student stud in studs)
                {
                    string[] row = { stud.Index.ToString(), stud.Nume, stud.Prenume};
                    candList.Items.Add(new ListViewItem(row));
                }
        }

        /// <summary>
        /// Load the list of the admited students for the specialization.
        /// </summary>
        private void LoadAdmisi()
        {
            candList.Items.Clear();
            if (specBox.Items.Count == 0)
                return;
            scandidati.Text = "Lista Admisi:";
            ISpecialization spec = controller.GetSpec(specBox.SelectedItem.ToString());
            List<IStudent> studs = controller.GetAllStudents();
            if (studs != null)
            {
                foreach (Student stud in studs)
                {
                    if (stud.Status().ToUpper() == "INTRAT" && stud.EnrolledSpec == spec)
                    {
                        string[] row = { stud.Index.ToString(), stud.Nume, stud.Prenume, "" };
                        candList.Items.Add(new ListViewItem(row));
                    }
                }
            }
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
        /// Update a spec from exterior source.
        /// </summary>
        /// <param name="specToUpdate"></param>
        public void UpdateSpec(ISpecialization specToUpdate)
        {
            if (specToUpdate == null)
                return;
            controller.UpdateSpec(specToUpdate);
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

        /// <summary>
        /// Save changes for student button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChB_Click(object sender, EventArgs e)
        {
            if (index.Text == ".")
                return;
            IStudent studentToUpdate = controller.GetStudById(Int32.Parse(index.Text));
            UpdateStudent(studentToUpdate);
        }

        /// <summary>
        /// Edit student button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editStudB_Click(object sender, EventArgs e)
        {
            if (index.Text == ".")
                return;
            IStudent studToEdit = controller.GetStudById(Int32.Parse(index.Text));
            IView editView = new EditStudV(studToEdit, this);
            editView.LoadView();
        }

        /// <summary>
        /// Edit Specialization button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editSpecB_Click(object sender, EventArgs e)
        {
            if (specID.Text == ".")
                return;
            ISpecialization specToEdit = controller.GetSpecById(Int32.Parse(specID.Text));
            IView editView = new EditSpecV(specToEdit, this);
            editView.LoadView();
        }

        /// <summary>
        /// Edit option butto function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editOpB_Click(object sender, EventArgs e)
        {
            if (optiuniList.SelectedItems.Count == 0)
                return;
            ListViewItem opToEdit = optiuniList.SelectedItems[0];
            IView editView = new EditOptionV(opToEdit, this);
            editView.LoadView();
        }

        /// <summary>
        /// Update a option in option list.
        /// </summary>
        /// <param name="opToUpdate"></param>
        public void UpdateOption(ListViewItem opToUpdate)
        {
            ListViewItem opToRemove = null;
            // verify if the new option already exist.
            for (int it = 0; it < optiuniList.Items.Count; it++)
            {
                if (optiuniList.Items[it].SubItems[1].Text.ToUpper() == opToUpdate.SubItems[1].Text.ToUpper()
                    && optiuniList.Items[it].SubItems[2].Text.ToUpper() == opToUpdate.SubItems[2].Text.ToUpper())
                {
                    if (optiuniList.Items[it].SubItems[0].Text.ToUpper() != opToUpdate.SubItems[0].Text.ToUpper())
                    {
                        opToRemove = optiuniList.Items[it];
                        RemoveOption(opToRemove);
                    }
                    else
                        return;
                }
            }
            for(int it = 0; it < optiuniList.Items.Count; it++)
            {
                if(optiuniList.Items[it].SubItems[0].Text.ToUpper() == opToUpdate.SubItems[0].Text.ToUpper())
                {
                    optiuniList.Items[it] = opToUpdate;
                    return;
                }
            }
        }

        public void RemoveOption(ListViewItem opToRemove)
        {
            if (opToRemove == null)
                return;
            optiuniList.Items.Remove(opToRemove);
        }

        private void seeAdmB_Click_1(object sender, EventArgs e)
        {
            LoadAdmisi();
        }

        private void seeCandB_Click_1(object sender, EventArgs e)
        {
            LoadCandidati();
        }

        public List<IOption> GetOptions()
        {
            return controller.GetOptions();
        }
    }
}
