using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pari_winform.Utils
{
    public class NavigationUtils
    {
        private Form ActiveForm = null;

        public void OpenChildPanel(Form childForm, Panel parentPanel)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            parentPanel.Controls.Add(childForm);
            parentPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
