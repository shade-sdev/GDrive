namespace GDrive
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.txtClientId = new Guna.UI.WinForms.GunaTextBox();
            this.lblClientId = new Guna.UI.WinForms.GunaLabel();
            this.lblClientSecret = new Guna.UI.WinForms.GunaLabel();
            this.txtSecret = new Guna.UI.WinForms.GunaTextBox();
            this.btnAuthorize = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnInfo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(506, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.RoyalBlue;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.DodgerBlue;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // txtClientId
            // 
            this.txtClientId.BackColor = System.Drawing.Color.Transparent;
            this.txtClientId.BaseColor = System.Drawing.Color.White;
            this.txtClientId.BorderColor = System.Drawing.Color.White;
            this.txtClientId.BorderSize = 1;
            this.txtClientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClientId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtClientId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClientId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClientId.Location = new System.Drawing.Point(73, 66);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.PasswordChar = '\0';
            this.txtClientId.Radius = 2;
            this.txtClientId.SelectedText = "";
            this.txtClientId.Size = new System.Drawing.Size(407, 30);
            this.txtClientId.TabIndex = 1;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClientId.ForeColor = System.Drawing.Color.White;
            this.lblClientId.Location = new System.Drawing.Point(73, 45);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(52, 15);
            this.lblClientId.TabIndex = 2;
            this.lblClientId.Text = "Client ID";
            // 
            // lblClientSecret
            // 
            this.lblClientSecret.AutoSize = true;
            this.lblClientSecret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClientSecret.ForeColor = System.Drawing.Color.White;
            this.lblClientSecret.Location = new System.Drawing.Point(73, 108);
            this.lblClientSecret.Name = "lblClientSecret";
            this.lblClientSecret.Size = new System.Drawing.Size(73, 15);
            this.lblClientSecret.TabIndex = 4;
            this.lblClientSecret.Text = "Client Secret";
            // 
            // txtSecret
            // 
            this.txtSecret.BackColor = System.Drawing.Color.Transparent;
            this.txtSecret.BaseColor = System.Drawing.Color.White;
            this.txtSecret.BorderColor = System.Drawing.Color.White;
            this.txtSecret.BorderSize = 1;
            this.txtSecret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecret.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSecret.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSecret.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSecret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecret.Location = new System.Drawing.Point(73, 129);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.PasswordChar = '\0';
            this.txtSecret.Radius = 2;
            this.txtSecret.SelectedText = "";
            this.txtSecret.Size = new System.Drawing.Size(407, 30);
            this.txtSecret.TabIndex = 3;
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.AnimationHoverSpeed = 0.07F;
            this.btnAuthorize.AnimationSpeed = 0.03F;
            this.btnAuthorize.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthorize.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnAuthorize.BorderColor = System.Drawing.Color.Black;
            this.btnAuthorize.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAuthorize.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAuthorize.CheckedForeColor = System.Drawing.Color.White;
            this.btnAuthorize.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAuthorize.CheckedImage")));
            this.btnAuthorize.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAuthorize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAuthorize.FocusedColor = System.Drawing.Color.Empty;
            this.btnAuthorize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAuthorize.ForeColor = System.Drawing.Color.White;
            this.btnAuthorize.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorize.Image")));
            this.btnAuthorize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAuthorize.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAuthorize.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAuthorize.Location = new System.Drawing.Point(186, 182);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnAuthorize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAuthorize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAuthorize.OnHoverImage = null;
            this.btnAuthorize.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAuthorize.OnPressedColor = System.Drawing.Color.Black;
            this.btnAuthorize.Radius = 2;
            this.btnAuthorize.Size = new System.Drawing.Size(163, 34);
            this.btnAuthorize.TabIndex = 5;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AnimationHoverSpeed = 0.07F;
            this.btnInfo.AnimationSpeed = 0.03F;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnInfo.BorderColor = System.Drawing.Color.Black;
            this.btnInfo.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnInfo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnInfo.CheckedForeColor = System.Drawing.Color.White;
            this.btnInfo.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.CheckedImage")));
            this.btnInfo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInfo.FocusedColor = System.Drawing.Color.Empty;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInfo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInfo.Location = new System.Drawing.Point(486, 66);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnInfo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInfo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInfo.OnHoverImage = null;
            this.btnInfo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInfo.OnPressedColor = System.Drawing.Color.Black;
            this.btnInfo.Radius = 2;
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAuthorize);
            this.Controls.Add(this.lblClientSecret);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.gunaControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaTextBox txtClientId;
        private Guna.UI.WinForms.GunaLabel lblClientId;
        private Guna.UI.WinForms.GunaLabel lblClientSecret;
        private Guna.UI.WinForms.GunaTextBox txtSecret;
        private Guna.UI.WinForms.GunaAdvenceButton btnAuthorize;
        private Guna.UI.WinForms.GunaAdvenceButton btnInfo;
    }
}