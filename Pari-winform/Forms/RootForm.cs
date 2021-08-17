using Pari_winform.Forms.AdminForms;
using Pari_winform.Forms.ClientForms;
using Pari_winform.Forms.PariForms;
using Pari_winform.Forms.VideoForms;
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
    public partial class RootContainer : Form
    {
        readonly NavigationUtils nav = new NavigationUtils();

        public RootContainer()
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
            nav.OpenChildPanel(new ListClientsForm(),childPanel);
            HideSubmenu();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            nav.OpenChildPanel(new AddClientForm(), childPanel);
            HideSubmenu();
        }

        private void btnImportClients_Click(object sender, EventArgs e)
        {
            nav.OpenChildPanel(new ImportClientForm(), childPanel);
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
            nav.OpenChildPanel(new ListParisForm(), childPanel);
            HideSubmenu();
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            nav.OpenChildPanel(new ShowStatsForm(), childPanel);
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
            nav.OpenChildPanel(new ListVideosForm(), childPanel);
            HideSubmenu();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            nav.OpenChildPanel(new AddVideoForm(), childPanel);
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
            nav.OpenChildPanel(new ListAdminForm(), childPanel);
            HideSubmenu();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            nav.OpenChildPanel(new AddAdminForm(), childPanel);
            HideSubmenu();
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //nav.loginForm.Show();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            var response = await AuthContoller.Login("rafahrafanomezantsoa@gmail.com", "abc123");
            OutputL.Text = response;
        }       
    }
}
      