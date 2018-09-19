using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.View
{
    public partial class FacultyV : Form, IView
    {
        public FacultyV()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {

        }

        private void students_Click(object sender, EventArgs e)
        {
            //load students list
        }
    }
}
