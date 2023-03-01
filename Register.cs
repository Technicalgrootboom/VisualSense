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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox[] bunifuTextBoxes = {txtAddr, txtCNo,txtEmail, txtFName, txtID, txtLName, txtPCode};
            String errMessage = "txt";
            
            foreach(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textBox in bunifuTextBoxes)
            {
                if(textBox.Text == "")
                {
                    switch (textBox.Name)
                    {
                        case "txtAddr":
                            errMessage += " Address,";
                            break;
                        case "txtCNo":
                            errMessage += " Cell Number,";
                            break;
                        case "txtEmail":
                            errMessage += " Email,";
                            break;
                        case "txtFName":
                            errMessage += " Full Name,";
                            break;
                        case "txtID":
                            errMessage += " ID,";
                            break;
                        case "txtLName":
                            errMessage += " Last Name,";
                            break;
                        case "txtPCode":
                            errMessage += " Postal Code,";
                            break;
                    }
                }
                if (textBox.Name == "txtPCode")
                {
                    errMessage += ".";
                }
            }
      

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Dashboard dashForm = new Dashboard();
            dashForm.Show();
            ((Form)MdiParent).Hide();
            this.Close();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Dashboard dashForm = new Dashboard();
            dashForm.ShowDialog();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }
    }
}
