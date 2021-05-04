using ByteSizeLib;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace GDrive
{
    public partial class GoogleDrive : Form
    {
        public delegate void clearDelegate(FlowLayoutPanel flp);
        public GoogleDrive()
        {
            InitializeComponent();
        }

        private static readonly googledriveapi gd = new googledriveapi();
        public static DriveService service = gd.Authorize();
        private double currentupload = 0;
        private double uploadfilesize = 0;
        private Guna.UI.WinForms.GunaProgressBar progressBar;
        private Google.Apis.Upload.IUploadProgress objectProgress;
        private delegate void fileDelegate(File file);

        private void GoogleDrive_Load(object sender, EventArgs e)
        {
            this.ActiveControl = flpMain;
            CheckForIllegalCrossThreadCalls = false;
     
            setDriveDetails();
            setUserEmail();
            syncUserThread();
            setSwitchUserMenu();
            setDriveFiles(gd.getDriveFiles(service, "'" + constants.email + "' in writers", "createdTime desc"));

        }


        private void setSwitchUserMenu()
        {
            ContextMenuStrip cm = new ContextMenuStrip();
            cm.Text = "Users";

            cm.ItemClicked += Cm_ItemClicked;
            string[] users = misc.searchFolder(Environment.CurrentDirectory + @"\Users");
            foreach (string user in users)
            {
                cm.Items.Add(System.IO.Path.GetFileName(user).ToString());
            }
            cm.Items.Add("Add Account");

            lblNameShort.ContextMenuStrip = cm;
        }

        private void Cm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Add Account")
            {
                System.IO.File.Delete(Environment.CurrentDirectory + @"\" + misc.searchFile(Environment.CurrentDirectory));
                Application.Restart();
            } else
            {
                if (item.Text == constants.email)
                {

                } else
                {
                    string root = Environment.CurrentDirectory + @"\Users\" + item.Text + @"\" + misc.searchFile(Environment.CurrentDirectory);
                    string dest = Environment.CurrentDirectory + @"\" + misc.searchFile(Environment.CurrentDirectory);
                    System.IO.File.Copy(root, dest, true);
                    Application.Restart();
                }
            }

        }

        private void syncUserThread()
        {
            Thread t = new Thread(new ThreadStart(syncUser));
            t.IsBackground = true;
            t.Start();
        }

        private void syncUser()
        {

            if (misc.searchFile(Environment.CurrentDirectory) == string.Empty)
            {
                gd.Authorize();
            }

            string dest = Environment.CurrentDirectory + @"\Users\" + constants.email + @"\" + misc.searchFile(Environment.CurrentDirectory);
            string root = Environment.CurrentDirectory + @"\" + misc.searchFile(Environment.CurrentDirectory);

            if (misc.checkTokenResponse() == true)
            {
                //Console.WriteLine("Token exists in root");
                if (misc.checkUserTokenDirectory() == true)
                {
                    //Console.WriteLine("User Directory Exists");
                    if (misc.checkUserTokenFile() == true)
                    {
                        //Console.WriteLine("User Token File Exists");
                        System.IO.File.Copy(root, dest, true);
                    } else
                    {
                        //Console.WriteLine("User Token File does not Exists");
                        System.IO.File.Copy(root, dest);
                        //Console.WriteLine("User Token File Created in user directory");
                    }
                } else
                {
                    //Console.WriteLine("User Directory does not Exists");
                    System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + @"\Users\" + constants.email);
                    //Console.WriteLine("User Directory Created");

                    if (misc.checkUserTokenFile() == true)
                    {
                        //Console.WriteLine("User Token File Exists");
                        System.IO.File.Copy(root, dest, true);
                    } else
                    {

                        //Console.WriteLine("User Token File does not Exists");
                        System.IO.File.Copy(root, dest);
                        //Console.WriteLine("User Token File Created in user directory");
                    }
                
                }
            } else
            {
                //Console.WriteLine("Token does not exists in root");
                gd.Authorize();
                //Console.WriteLine("Token created in root");
            }
        }


        private void setDriveFiles(IList<File> files)
        {
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {

                    flpMain.Invoke(new fileDelegate(setDriveFilesUIFunc), file);
               


                }
            }
        }

        private void setDriveFilesUIFunc(File file)
        {
            var t = new Thread(() => setDriveFilesUI(file));
            t.IsBackground = true;
            t.Start();

        }

        private void setDriveFilesUI(File file)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    if (misc.getFileExtention(file.Name) != string.Empty)
                    {
              

                        FileItem fileItem = new FileItem();
                        fileItem.fileIcon.BackgroundImage = misc.getFileIcon(misc.getFileExtention(file.Name));
                        fileItem.name.Text = file.Name;
                        fileItem.size.Text = ByteSize.FromBytes((double)file.Size).ToString();
                        fileItem.date.Text = file.CreatedTime.ToString();
                        fileItem.share.Tag = file.WebViewLink;
                        fileItem.name.Tag = file.WebViewLink;
                        fileItem.name.Click += Share_Click;
                        fileItem.share.Click += Share_Click;
                        fileItem.delete.Click += Delete_Click;
                        fileItem.delete.Name = file.Id;
                        flpMain.Controls.Add(fileItem);
                    }
                });
            }

        }



        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult delDialog = MessageBox.Show("Are you sure?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delDialog == DialogResult.Yes)
            {
                var btnDelete = (Guna.UI.WinForms.GunaPictureBox)sender;
                gd.deleteFile(service, btnDelete.Name);
                clearFlpFunc(flpMain);
                setDriveFiles(gd.getDriveFiles(service, "'" + constants.email + "' in writers", "createdTime desc"));
                setDriveDetails();
            }
    
        }

        private void Share_Click(object sender, EventArgs e)
        {
            
            try { var btnShare = (Guna.UI.WinForms.GunaPictureBox)sender;
                Process.Start(btnShare.Tag.ToString());
            } catch { }
            try { var btnShare = (Guna.UI.WinForms.GunaLabel)sender;
                Process.Start(btnShare.Tag.ToString());
            } catch { }
       
        }

  

        private void setDriveDetails()
        {

            About about = gd.getUserDriveInfo(service);
            constants.email = about.User.EmailAddress;
            constants.avatarLetter = constants.email.Substring(0, 1);
            constants.emailWithoutDomain = constants.email.Replace("@gmail.com", "");
            double usage = about.StorageQuota.Usage.Value;
            double size = about.StorageQuota.Limit.Value;
            lblStorageText.Text = ByteSize.FromBytes(usage) + " of " + ByteSize.FromBytes(size) + " used";
            long progress = ((long)(100 / size * usage));
            storageProgress.Value = (int)progress;

        }

        private void setUserEmail()
        {
            lblNameShort.Text = constants.avatarLetter.ToUpper();
            lblName.Text = constants.emailWithoutDomain;
        }

        private void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        {
            objectProgress = obj;
            
            currentupload = obj.BytesSent;
        }

        private async void uploadFileProcess(string path)
        {
            btnUpload.Enabled = false;
            this.AllowDrop = false;
            try
            {
                System.IO.FileInfo fI = new System.IO.FileInfo(path);
                uploadfilesize = fI.Length;
                FilesResource.CreateMediaUpload request = gd.uploadFile(service, path, "");
                request.Fields = "id";
                request.ProgressChanged += Request_ProgressChanged;
                FileItemUpload fileItemUpload = new FileItemUpload();
                fileItemUpload.name.Text = System.IO.Path.GetFileName(path).ToString();
                fileItemUpload.fileIcon.BackgroundImage = misc.getFileIcon(misc.getFileExtention(System.IO.Path.GetFileName(path).ToString()));
                fileItemUpload.size.Text = ByteSize.FromBytes((double)fI.Length).ToString();
                progressBar = fileItemUpload.progress;
                flpMain.Controls.Add(fileItemUpload);
                flpMain.Controls.SetChildIndex(fileItemUpload, 0);
                timer1.Enabled = true;
                timer1.Start();
                 await request.UploadAsync();
                gd.filePermission("anyone", request.ResponseBody.Id);


          
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                btnUpload.Enabled = true;
                this.AllowDrop = true;
            }
     
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".*";
            ofd.Filter = "All File|*.*";
            ofd.ShowDialog();
            path = ofd.FileName;
            uploadFileProcess(path);
        }

        void clearFlpFunc(FlowLayoutPanel flp)
        {
            if (InvokeRequired)
            {
                Invoke(new clearDelegate(clearFlpFunc), flp);
                return;
            }

            misc.clearFlp<GoogleDrive>(flpMain);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                decimal first = ((decimal)(100 / uploadfilesize * currentupload));

                progressBar.Value = ((int)first);

            }
            catch { }

            if (objectProgress.Status == Google.Apis.Upload.UploadStatus.Completed)
            {
                timer1.Enabled = false;
                timer1.Stop();
                currentupload = 0;
                uploadfilesize = 0;
                progressBar.Value = 100;
                clearFlpFunc(flpMain);
                setDriveFiles(gd.getDriveFiles(service, "'" + constants.email + "' in writers", "createdTime desc"));
                btnUpload.Enabled = true;
                this.AllowDrop = true;
            }
        }

        private void GoogleDrive_DragEnter(object sender, DragEventArgs e)
            {
                try { 
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string path = fileList[0];
                uploadFileProcess(path);
                } catch
                {

                }
            }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clearFlpFunc(flpMain);
                setDriveFiles(gd.getDriveFiles(service, "'" + constants.email + "' in writers and name contains '"+txtSearch.Text+"'", "createdTime desc"));
            }
        }

        private void txtSearchLostFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
                txtSearch.Text = "Search Drive...";
        }

        private void txtSearchOnFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Drive..." && txtSearch.Text != string.Empty)
                txtSearch.Text = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            misc.showdialog(settings);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "chrome.exe"; 
            myProcess.StartInfo.Arguments = Environment.CurrentDirectory + @"\" + "index.html";
            myProcess.Start();
        }
    }

    }



