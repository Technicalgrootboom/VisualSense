namespace VisualSense
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVisualSense = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.EXIT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.REG = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LOGIN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisualSense
            // 
            this.lblVisualSense.AutoSize = true;
            this.lblVisualSense.BackColor = System.Drawing.Color.White;
            this.lblVisualSense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualSense.Location = new System.Drawing.Point(814, 636);
            this.lblVisualSense.Name = "lblVisualSense";
            this.lblVisualSense.Size = new System.Drawing.Size(188, 20);
            this.lblVisualSense.TabIndex = 5;
            this.lblVisualSense.Text = "Powered by Visual Sense";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderColor = System.Drawing.Color.Blue;
            this.MainPanel.Controls.Add(this.EXIT);
            this.MainPanel.Controls.Add(this.REG);
            this.MainPanel.Controls.Add(this.LOGIN);
            this.MainPanel.Location = new System.Drawing.Point(1, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.PanelColor = System.Drawing.Color.Transparent;
            this.MainPanel.ShadowDept = 2;
            this.MainPanel.ShadowTopLeftVisible = false;
            this.MainPanel.Size = new System.Drawing.Size(187, 676);
            this.MainPanel.TabIndex = 7;
            this.MainPanel.Enter += new System.EventHandler(this.MainPanel_Enter);
            this.MainPanel.Leave += new System.EventHandler(this.MainPanel_Leave);
            // 
            // EXIT
            // 
            this.EXIT.Active = false;
            this.EXIT.Activecolor = System.Drawing.Color.Transparent;
            this.EXIT.BackColor = System.Drawing.Color.Transparent;
            this.EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EXIT.BorderRadius = 0;
            this.EXIT.ButtonText = "    Exit";
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.DisabledColor = System.Drawing.Color.Gray;
            this.EXIT.Iconcolor = System.Drawing.Color.Transparent;
            this.EXIT.Iconimage = global::VisualSense.Properties.Resources.LogOut;
            this.EXIT.Iconimage_right = null;
            this.EXIT.Iconimage_right_Selected = null;
            this.EXIT.Iconimage_Selected = null;
            this.EXIT.IconMarginLeft = 0;
            this.EXIT.IconMarginRight = 0;
            this.EXIT.IconRightVisible = true;
            this.EXIT.IconRightZoom = 0D;
            this.EXIT.IconVisible = true;
            this.EXIT.IconZoom = 90D;
            this.EXIT.IsTab = false;
            this.EXIT.Location = new System.Drawing.Point(3, 303);
            this.EXIT.Name = "EXIT";
            this.EXIT.Normalcolor = System.Drawing.Color.Transparent;
            this.EXIT.OnHovercolor = System.Drawing.Color.Transparent;
            this.EXIT.OnHoverTextColor = System.Drawing.Color.Blue;
            this.EXIT.selected = false;
            this.EXIT.Size = new System.Drawing.Size(179, 59);
            this.EXIT.TabIndex = 8;
            this.EXIT.Text = "    Exit";
            this.EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EXIT.Textcolor = System.Drawing.Color.DeepSkyBlue;
            this.EXIT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // REG
            // 
            this.REG.Active = false;
            this.REG.Activecolor = System.Drawing.Color.Transparent;
            this.REG.BackColor = System.Drawing.Color.Transparent;
            this.REG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REG.BorderRadius = 0;
            this.REG.ButtonText = "    Register";
            this.REG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REG.DisabledColor = System.Drawing.Color.Gray;
            this.REG.Iconcolor = System.Drawing.Color.Transparent;
            this.REG.Iconimage = global::VisualSense.Properties.Resources.Register;
            this.REG.Iconimage_right = null;
            this.REG.Iconimage_right_Selected = null;
            this.REG.Iconimage_Selected = null;
            this.REG.IconMarginLeft = 0;
            this.REG.IconMarginRight = 0;
            this.REG.IconRightVisible = true;
            this.REG.IconRightZoom = 0D;
            this.REG.IconVisible = true;
            this.REG.IconZoom = 90D;
            this.REG.IsTab = false;
            this.REG.Location = new System.Drawing.Point(0, 238);
            this.REG.Name = "REG";
            this.REG.Normalcolor = System.Drawing.Color.Transparent;
            this.REG.OnHovercolor = System.Drawing.Color.Transparent;
            this.REG.OnHoverTextColor = System.Drawing.Color.Blue;
            this.REG.selected = false;
            this.REG.Size = new System.Drawing.Size(179, 59);
            this.REG.TabIndex = 8;
            this.REG.Text = "    Register";
            this.REG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.REG.Textcolor = System.Drawing.Color.DeepSkyBlue;
            this.REG.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REG.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Active = false;
            this.LOGIN.Activecolor = System.Drawing.Color.Transparent;
            this.LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOGIN.BorderRadius = 0;
            this.LOGIN.ButtonText = "    Log In";
            this.LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGIN.DisabledColor = System.Drawing.Color.Gray;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Iconcolor = System.Drawing.Color.Transparent;
            this.LOGIN.Iconimage = global::VisualSense.Properties.Resources.Login;
            this.LOGIN.Iconimage_right = null;
            this.LOGIN.Iconimage_right_Selected = null;
            this.LOGIN.Iconimage_Selected = null;
            this.LOGIN.IconMarginLeft = 0;
            this.LOGIN.IconMarginRight = 0;
            this.LOGIN.IconRightVisible = true;
            this.LOGIN.IconRightZoom = 0D;
            this.LOGIN.IconVisible = true;
            this.LOGIN.IconZoom = 90D;
            this.LOGIN.IsTab = false;
            this.LOGIN.Location = new System.Drawing.Point(0, 172);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Normalcolor = System.Drawing.Color.Transparent;
            this.LOGIN.OnHovercolor = System.Drawing.Color.Transparent;
            this.LOGIN.OnHoverTextColor = System.Drawing.Color.Blue;
            this.LOGIN.selected = false;
            this.LOGIN.Size = new System.Drawing.Size(179, 59);
            this.LOGIN.TabIndex = 8;
            this.LOGIN.Text = "    Log In";
            this.LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LOGIN.Textcolor = System.Drawing.Color.DeepSkyBlue;
            this.LOGIN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::VisualSense.Properties.Resources.Education_Wallpapers_HD_Free_Download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.lblVisualSense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVisualSense;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel MainPanel;
        private Bunifu.Framework.UI.BunifuFlatButton LOGIN;
        private Bunifu.Framework.UI.BunifuFlatButton REG;
        private Bunifu.Framework.UI.BunifuFlatButton EXIT;
    }
}

