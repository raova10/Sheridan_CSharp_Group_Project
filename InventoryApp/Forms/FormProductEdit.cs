using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp {
    public partial class FormProductEdit : Form {
        public FormProductEdit() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
