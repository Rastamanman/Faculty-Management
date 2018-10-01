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
    public partial class OptionV : Form, IView
    {
        IController controller;
        FacultyV view;

        public OptionV(FacultyV st)
        {
            InitializeComponent();
            view = st;
        }

        private void OptionV_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load the view.
        /// </summary>
        public void LoadView()
        {
            UpdateInfo();
            this.Enable();
        }

        public void UpdateInfo()
        {
            List<IOption> opts = view.GetOptions();
            foreach(IOption opt in opts)
            {
                optionsList.Items.Add(opt.ToString());
            }
        }

        /// <summary>
        /// Clear the view data.
        /// </summary>
        public void ClearView()
        {
            spec.Clear();
            buget.Checked = false;
        }

        /// <summary>
        /// Setter for the controller.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IController cont)
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
        /// Add option to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOpB_Click(object sender, EventArgs e)
        {
            if (view.HaveSpec(spec.Text))
                view.AddOp(this);
            else
                MessageBox.Show("Specialization does not exist!", "Specialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Getter for the row for option list.
        /// </summary>
        /// <returns></returns>
        public string[] GetRow()
        {
            string[] row = { "", spec.Text, "" };
            if (buget.Checked == true)
                row[2] = "Buget";
            else
                row[2] = "Taxa";
            return row;
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
