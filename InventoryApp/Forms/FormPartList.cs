using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.Forms
{
    public partial class FormPartList : Form
    {
        public FormPartList()
        {
            InitializeComponent();
        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            FormAddPart formAddPart = new FormAddPart();
            formAddPart.Show();
        }

        private void FormPartList_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPartEdit formPartEdit = new FormPartEdit();
            formPartEdit.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
