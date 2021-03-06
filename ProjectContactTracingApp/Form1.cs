using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectContactTracingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectContactTracingAppDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.projectContactTracingAppDataSet.Persons);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            personsBindingSource.AddNew();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            personsBindingSource.RemoveCurrent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveLast();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            personsBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            personsBindingSource.EndEdit();
            personsTableAdapter.Update(projectContactTracingAppDataSet.Persons);
            MessageBox.Show("Succesfully Save!");
        }
    }
}
