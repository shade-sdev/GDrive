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
    public partial class FileItem : UserControl
    {
        public FileItem()
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

        public Guna.UI.WinForms.GunaPictureBox share
        {
            get { return picShare; }
            set { picShare = value; }
        }

        public Guna.UI.WinForms.GunaPictureBox delete
        {
            get { return picDelete; }
            set { picDelete = value; }
        }

        public Guna.UI.WinForms.GunaPictureBox fileIcon
        {
            get { return picFileIcon; }
            set { picFileIcon = value; }
        }
    }
}
