using Pari_winform.Forms.ClientForms;
using Pari_winform.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pari_winform
{
    public partial class ListClientsForm : Form
    {
        NavigationUtils nav = new NavigationUtils();
        public ListClientsForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNavigateToEdit_Click(object sender, EventArgs e)
        {
            Panel parentPanel = (Panel)this.Parent;
            nav.OpenChildPanel(new EditClientForm(), parentPanel);
            this.Close();
        }
    }
}
