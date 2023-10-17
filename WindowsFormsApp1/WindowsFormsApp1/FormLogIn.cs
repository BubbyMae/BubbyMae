using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogIn : Form
    {
        Form1 fgrid;
        public FormLogIn(Form1 fgrid)
        {
            InitializeComponent();
            this.fgrid = fgrid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fgrid.dataGridView1.Rows.Add(textBoxName.Text, textBoxCourse.Text, textBoxYlvl.Text);
        }
    }
}
