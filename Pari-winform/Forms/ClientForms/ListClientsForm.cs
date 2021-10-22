using Pari_winform.Forms.ClientForms;
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

namespace Pari_winform
{
    public partial class ListClientsForm : Form
    {
        NavigationUtils nav = new NavigationUtils();
        int init_page = 1;
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

        private async void ListClientsForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            var response = await ClientController.GetListClient(init_page, 7);
            dataGridView1.DataSource = response.clients;
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

        private async void sv_lst_client_Click(object sender, EventArgs e)
        {
            init_page++;
            var response = await ClientController.GetListClient(init_page, 7);
            dataGridView1.DataSource = response.clients;
            dataGridView1.Refresh();
        }

        private async void pv_lst_client_Click(object sender, EventArgs e)
        {
            if(init_page <= 1) 
            {
                init_page = 1;
            }
            else
            {
                init_page--;
            }
            var response = await ClientController.GetListClient(init_page, 7);
            dataGridView1.DataSource = response.clients;
            dataGridView1.Refresh();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
