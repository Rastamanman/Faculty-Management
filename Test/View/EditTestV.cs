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
    public partial class EditTestV : Form, IView
    {
        IController cont;
        FacultyV dest;
        ListViewItem test;

        public EditTestV(ListViewItem itm, FacultyV dest)
        {
            this.dest = dest;
            test = itm;
            InitializeComponent();
        }

        public void SetController(IController cont)
        {
            this.cont = cont;
        }

        public void Enable()
        {
            this.Visible = false;
            this.ShowDialog();
        }

        public void Disable()
        {
            this.Visible = false;
            this.Enabled = false;
        }

        public void LoadView()
        {
            LoadInfo();
            SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            this.Enable();
        }

        public void LoadInfo()
        {
            nume.Text = test.SubItems[1].Text;
            req.Text = test.SubItems[2].Text;
            pond.Text = test.SubItems[3].Text;
        }

        public void UpdateInfo()
        {
            string[] row = { test.SubItems[0].Text, nume.Text, req.Text, pond.Text };
            test = new ListViewItem(row);
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void editB_Click(object sender, EventArgs e)
        {
            UpdateInfo();
            dest.EditTest(test);
        }
    }
}
