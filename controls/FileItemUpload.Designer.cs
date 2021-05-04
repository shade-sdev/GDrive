namespace GDrive
{
    partial class FileItemUpload
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
            this.picFileIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.lblFileSize = new Guna.UI.WinForms.GunaLabel();
            this.lblCreateDate = new Guna.UI.WinForms.GunaLabel();
            this.lblFileName = new Guna.UI.WinForms.GunaLabel();
            this.fileItemUploadProgress = new Guna.UI.WinForms.GunaProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picFileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picFileIcon
            // 
            this.picFileIcon.BackgroundImage = global::GDrive.Properties.Resources.icons8_exe_48px;
            this.picFileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFileIcon.BaseColor = System.Drawing.Color.White;
            this.picFileIcon.Location = new System.Drawing.Point(32, 12);
            this.picFileIcon.Name = "picFileIcon";
            this.picFileIcon.Size = new System.Drawing.Size(30, 30);
            this.picFileIcon.TabIndex = 13;
            this.picFileIcon.TabStop = false;
            // 
            // lblFileSize
            // 
            this.lblFileSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(188)))), ((int)(((byte)(203)))));
            this.lblFileSize.Location = new System.Drawing.Point(525, 14);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(61, 23);
            this.lblFileSize.TabIndex = 10;
            this.lblFileSize.Text = "900 MB";
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(188)))), ((int)(((byte)(203)))));
            this.lblCreateDate.Location = new System.Drawing.Point(343, 14);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(153, 23);
            this.lblCreateDate.TabIndex = 9;
            this.lblCreateDate.Text = "Sept 9, 2019 12:42 AM";
            this.lblCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFileName.Location = new System.Drawing.Point(82, 8);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(227, 23);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "Weekly Reports.docx";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileItemUploadProgress
            // 
            this.fileItemUploadProgress.BackColor = System.Drawing.Color.Transparent;
            this.fileItemUploadProgress.BorderColor = System.Drawing.Color.Black;
            this.fileItemUploadProgress.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.fileItemUploadProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.fileItemUploadProgress.Location = new System.Drawing.Point(85, 35);
            this.fileItemUploadProgress.Name = "fileItemUploadProgress";
            this.fileItemUploadProgress.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.fileItemUploadProgress.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.fileItemUploadProgress.Radius = 1;
            this.fileItemUploadProgress.Size = new System.Drawing.Size(150, 5);
            this.fileItemUploadProgress.TabIndex = 14;
            // 
            // FileItemUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileItemUploadProgress);
            this.Controls.Add(this.picFileIcon);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblFileName);
            this.Name = "FileItemUpload";
            this.Size = new System.Drawing.Size(760, 55);
            ((System.ComponentModel.ISupportInitialize)(this.picFileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox picFileIcon;
        private Guna.UI.WinForms.GunaLabel lblFileSize;
        private Guna.UI.WinForms.GunaLabel lblCreateDate;
        private Guna.UI.WinForms.GunaLabel lblFileName;
        private Guna.UI.WinForms.GunaProgressBar fileItemUploadProgress;
    }
}
