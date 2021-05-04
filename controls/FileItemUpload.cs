using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDrive
{
    public partial class FileItemUpload : UserControl
    {
        public FileItemUpload()
        {
            InitializeComponent();
        }

        public Guna.UI.WinForms.GunaLabel name
        {
            get { return lblFileName; }
            set { lblFileName = value; }
        }

        public Guna.UI.WinForms.GunaLabel size
        {
            get { return lblFileSize; }
            set { lblFileSize = value; }
        }

        public Guna.UI.WinForms.GunaLabel date
        {
            get { return lblCreateDate; }
            set { lblCreateDate = value; }
        }


        public Guna.UI.WinForms.GunaPictureBox fileIcon
        {
            get { return picFileIcon; }
            set { picFileIcon = value; }
        }

        public Guna.UI.WinForms.GunaProgressBar progress
        {
            get { return fileItemUploadProgress; }
            set { fileItemUploadProgress = value; }
        }
    }
}
