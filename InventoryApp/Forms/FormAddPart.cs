﻿using System;
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
    public partial class FormAddPart : Form
    {
        public FormAddPart()
        {
            InitializeComponent();
        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
