using Pari_winform.Forms.AdminForms;
using Pari_winform.Forms.ClientForms;
using Pari_winform.Forms.PariForms;
using Pari_winform.Forms.VideoForms;
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
    public partial class rootContainer : Form
    {
        public rootContainer()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelSubmenuClients.Visible = false;
            panelSubmenuPari.Visible = false;
            panelSubmenuVideo.Visible = false;
            panelSubmenuAdministrator.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panelSubmenuClients.Visible == true)
            {
                panelSubmenuClients.Visible = false;
            }
            if(panelSubmenuPari.Visible == true)
            {
                panelSubmenuPari.Visible = false;
            }
            if (panelSubmenuVideo.Visible == true)
            {
                panelSubmenuVideo.Visible = false;
            }
            if(panelSubmenuAdministrator.Visible == true)
            {
                panelSubmenuAdministrator.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #region Clients
        private void btnMenuClients_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuClients);
        }

        private void btnListClients_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ListClientsForm());
            HideSubmenu();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new AddClientForm());
            HideSubmenu();
        }

        private void btnImportClients_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ImportClientForm());
            HideSubmenu();
        }
        #endregion

        #region Pari
        private void btnMenuPari_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuPari);
        }

        private void btnListPari_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ListParisForm());
            HideSubmenu();
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ShowStatsForm());
            HideSubmenu();
        }
        #endregion

        #region Video
        private void btnMenuVideos_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuVideo);
        }

        private void btnListVideos_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ListVideosForm());
            HideSubmenu();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new AddVideoForm());
            HideSubmenu();
        }
        #endregion

        #region Administrateur
        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuAdministrator);
        }

        private void btnListAdmins_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ListAdminForm());
            HideSubmenu();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new AddAdminForm());
            HideSubmenu();
        }
        #endregion

        private Form ActiveForm = null;
        private void OpenChildPanel(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
