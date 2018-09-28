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
    public partial class EditOptionV : Form, IView
    {
        IController cont;
        FacultyV dest;
        ListViewItem op;

        public EditOptionV(ListViewItem op, FacultyV dest)
        {
            this.dest = dest;
            this.op = op;
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
        /// Load Info from object.
        /// </summary>
        public void LoadInfo()
        {
            nume.Text = op.SubItems[1].Text;
            if (op.SubItems[2].Text.ToUpper() == "BUGET")
                buget.Checked = true;
            else
                buget.Checked = false;
        }

        /// <summary>
        /// Update object from view info.
        /// </summary>
        public void UpdateOption()
        {
            string[] row = { op.SubItems[0].Text, nume.Text, "" };
            if (buget.Checked == true)
                row[2] = "Buget";
            else
                row[2] = "Taxa";
            op = new ListViewItem(row);
        }

        /// <summary>
        /// Save button function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveB_Click(object sender, EventArgs e)
        {
            UpdateOption();
            if (dest.HaveSpec(op.SubItems[1].Text) == false)
            { 
                MessageBox.Show("Specialization does not exist!", "Specialization Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dest.UpdateOption(op);
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
