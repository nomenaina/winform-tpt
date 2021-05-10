﻿using Pari_winform.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pari_winform.Forms.AdminForms
{
    public partial class ListAdminForm : Form
    {
        NavigationUtils nav = new NavigationUtils();
        public ListAdminForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNavigateToEdit_Click(object sender, EventArgs e)
        {
            Panel parentContainer = (Panel)this.Parent;
            nav.OpenChildPanel(new EditAdminForm(), parentContainer);
            this.Close();
        }
    }
}
