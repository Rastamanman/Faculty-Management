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

namespace Proiect.View
{
    public partial class OptionV : Form, IStudentView
    {
        IStudentController controller;
        IFacultyView view;

        public OptionV(IFacultyView st)
        {
            InitializeComponent();
            view = st;
        }

        public void LoadView()
        {

        }

        /// <summary>
        /// Setter for the controller.
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IStudentController cont)
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
            view.AddOp();
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
