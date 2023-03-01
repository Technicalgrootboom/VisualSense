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
    public partial class logIn : Form
    {
        public Boolean loggedIn = false;
        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //Validate
            
            ((Form)this.MdiParent).Controls["MainPanel"].Width = 65;
            foreach (Form form in MdiParent.MdiChildren)
            {
                MessageBox.Show(form.ToString());
            }

            ((Form)this.MdiParent).Hide();
            Dashboard dashBoard = new Dashboard();
            dashBoard.Show();

        }

    }
}