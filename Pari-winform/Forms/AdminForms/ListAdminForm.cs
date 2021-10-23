using Pari_winform.Utils;
using Services.Controllers;
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
        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private async void ListAdminForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            var response = await AdminController.GetListAdmins();
            dataGridView1.DataSource = response.admins;
        }
    }
}
