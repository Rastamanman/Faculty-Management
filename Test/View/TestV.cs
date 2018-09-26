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
using Proiect.View;
using Proiect.Controller;

namespace Proiect.View
{
    public partial class TestV : Form, IView
    {
        IController cont;
        ITest test;
        FacultyV dest;

        public TestV(FacultyV dest)
        {
            this.dest = dest;
            InitializeComponent();
        }
        
        private void TestV_Load(object sender, EventArgs e)
        {

        }

        public void LoadView()
        {

        }

        /// <summary>
        /// Clear the view data.
        /// </summary>
        public void ClearView()
        {
            nume.Clear();
            pondere.Clear();
            req.Clear();
        }

        /// <summary>
        /// Setter for controller.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IController cont)
        {
            this.cont = cont;
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
        /// Load the test object from the view info.
        /// </summary>
        public void LoadTest()
        {
            test = new Proiect.Models.Test(nume.Text, Int32.Parse(pondere.Text), Int32.Parse(req.Text));
        }

        /// <summary>
        /// Add the new test button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTestB_Click(object sender, EventArgs e)
        {
            LoadTest();
            dest.AddNewTest(test);
            ClearView();
        }

        /// <summary>
        /// Cancel button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Disable();
        }
    }
}
