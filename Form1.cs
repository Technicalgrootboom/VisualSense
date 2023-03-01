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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ClearForms();
            MainPanel.Width = 65;
            
            Register regForm = new Register()            
            {
               MdiParent = this
            };
            

            regForm.StartPosition = FormStartPosition.Manual;
            regForm.Location = new Point(200,50);
            regForm.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ClearForms();
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ClearForms();
            MainPanel.Width = 65;
            logIn logIn = new logIn
            {
                MdiParent = this
            };
            
            logIn.StartPosition = FormStartPosition.Manual;
            logIn.Location = new Point(250, 90);
            logIn.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       private void ClearForms()
       {
            foreach (Form frm in this.MdiChildren)
            {
                try
                {
                    frm.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Error");
                }
            }
       }

        private void MainPanel_Enter(object sender, EventArgs e)
        {
            MainPanel.Width = 187;
        }

        private void MainPanel_Leave(object sender, EventArgs e)
        {
            MainPanel.Width = 65;
        }
    }
}
