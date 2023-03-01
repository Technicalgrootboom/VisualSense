using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSense
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

#pragma warning disable IDE1006 // Naming Styles

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ShowOnly(tabHome);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ShowOnly(tabHome);

;       }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ShowOnly(tabProfile);
        }  

        private void BtnApplications_Click(object sender, EventArgs e)
        {
            ShowOnly(tabApplications);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ShowOnly(tabDashboard);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ShowOnly(tabLogOut);
        }

        private void ShowOnly(TabPage tab)
        {
            TabPage[] tabPages = { tabHome, tabProfile, tabApplications, tabDashboard, tabLogOut };

            foreach (TabPage page in tabPages)
            {
                Dashboard_Tab.TabPages.Remove(page);
            }

            Dashboard_Tab.TabPages.Add(tab);
        }
    }
}
