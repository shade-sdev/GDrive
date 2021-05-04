using System.Windows.Forms;

namespace GDrive
{
    partial class FileItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileItem));
            this.mainSeperator = new Guna.UI.WinForms.GunaSeparator();
            this.lblFileName = new Guna.UI.WinForms.GunaLabel();
            this.lblCreateDate = new Guna.UI.WinForms.GunaLabel();
            this.lblFileSize = new Guna.UI.WinForms.GunaLabel();
            this.fileItemToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picFileIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.picDelete = new Guna.UI.WinForms.GunaPictureBox();
            this.picShare = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShare)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSeperator
            // 
            this.mainSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.mainSeperator.Location = new System.Drawing.Point(0, 48);
            this.mainSeperator.Name = "mainSeperator";
            this.mainSeperator.Size = new System.Drawing.Size(760, 10);
            this.mainSeperator.TabIndex = 0;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFileName.Location = new System.Drawing.Point(84, 15);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(227, 23);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Weekly Reports.docx";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileItemToolTip.SetToolTip(this.lblFileName, "Open");
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(188)))), ((int)(((byte)(203)))));
            this.lblCreateDate.Location = new System.Drawing.Point(345, 15);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(153, 23);
            this.lblCreateDate.TabIndex = 2;
            this.lblCreateDate.Text = "Sept 9, 2019 12:42 AM";
            this.lblCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFileSize
            // 
            this.lblFileSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(188)))), ((int)(((byte)(203)))));
            this.lblFileSize.Location = new System.Drawing.Point(527, 15);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(61, 23);
            this.lblFileSize.TabIndex = 4;
            this.lblFileSize.Text = "900 MB";
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileItemToolTip
            // 
            this.fileItemToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.fileItemToolTip.ToolTipTitle = "GDrive";
            // 
            // picFileIcon
            // 
            this.picFileIcon.BackgroundImage = global::GDrive.Properties.Resources.icons8_exe_48px;
            this.picFileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFileIcon.BaseColor = System.Drawing.Color.White;
            this.picFileIcon.Location = new System.Drawing.Point(34, 13);
            this.picFileIcon.Name = "picFileIcon";
            this.picFileIcon.Size = new System.Drawing.Size(30, 30);
            this.picFileIcon.TabIndex = 7;
            this.picFileIcon.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDelete.BackgroundImage")));
            this.picDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDelete.BaseColor = System.Drawing.Color.White;
            this.picDelete.Location = new System.Drawing.Point(703, 17);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(20, 20);
            this.picDelete.TabIndex = 6;
            this.picDelete.TabStop = false;
            this.fileItemToolTip.SetToolTip(this.picDelete, "Delete file.");
            // 
            // picShare
            // 
            this.picShare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picShare.BackgroundImage")));
            this.picShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShare.BaseColor = System.Drawing.Color.White;
            this.picShare.Location = new System.Drawing.Point(631, 17);
            this.picShare.Name = "picShare";
            this.picShare.Size = new System.Drawing.Size(20, 20);
            this.picShare.TabIndex = 5;
            this.picShare.TabStop = false;
            this.fileItemToolTip.SetToolTip(this.picShare, "Clicking on this Icon will open this file\'s Share Link on your browser.");
            // 
            // FileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picFileIcon);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picShare);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.mainSeperator);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FileItem";
            this.Size = new System.Drawing.Size(760, 55);
            ((System.ComponentModel.ISupportInitialize)(this.picFileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaSeparator mainSeperator;
        private Guna.UI.WinForms.GunaLabel lblFileName;
        private Guna.UI.WinForms.GunaLabel lblCreateDate;
        private Guna.UI.WinForms.GunaLabel lblFileSize;
        private Guna.UI.WinForms.GunaPictureBox picShare;
        private Guna.UI.WinForms.GunaPictureBox picDelete;
        private Guna.UI.WinForms.GunaPictureBox picFileIcon;
        private ToolTip fileItemToolTip;
    }
}
