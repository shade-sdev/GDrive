using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GDrive
{
    class misc
    {
 
        public static void setSetting(string path, int count, string textbox)
        {
            string[] lines = File.ReadAllLines(path);
            lines[count] = textbox;
            File.WriteAllLines(path, lines);
        }

        public static string getSetting(string path, int count, int substring)
        {
            string[] allLines = File.ReadAllLines(path);
            string randomLine = allLines[count];
            return randomLine.Substring(substring);
        }

        public static void showdialog(Form form)
        {

            form.ShowDialog();
        }

        public static Thread clearFlp<T>(FlowLayoutPanel flp) where T : Control
        {
            Thread t = null;
            foreach (Control item in flp.Controls.OfType<T>())
            {
                t = new Thread(() => clearFLP(flp, item));
                t.Start();
                return t;

            }

            flp.Controls.Clear();
            return t;
        }

        public static void clearFLP(FlowLayoutPanel flp, Control item)
        {
            flp.Controls.Remove(item);
        }

   

        public static string getFileExtention(string filename)
        {
            return Path.GetExtension(filename);
        }

        public static System.Drawing.Bitmap getFileIcon(string extension)
        {
            switch(extension)
            {
                case ".aac":
                    return constants.AAC;

                case ".apk":
                    return constants.APK;

                case ".avi":
                    return constants.AVI;

                case ".css":
                    return constants.CSS;

                case ".csv":
                    return constants.CSV;

                case ".exe":
                    return constants.EXE;

                case ".flv":
                    return constants.FLV;

                case ".gif":
                    return constants.GIF;

                case ".html":
                    return constants.HTML;

                case ".jpg":
                    return constants.JPG;

                case ".json":
                    return constants.JSON;

                case ".xls":
                    return constants.XLS;

                case ".mkv":
                    return constants.MKV;

                case ".mp3":
                    return constants.MP3;

                case ".mp4":
                    return constants.MP4;

                case ".pdf":
                    return constants.PDF;

                case ".png":
                    return constants.PNG;

                case ".ppt":
                    return constants.PPT;

                case ".rar":
                    return constants.RAR;

                case ".tar":
                    return constants.TAR;

                case ".txt":
                    return constants.TXT;

                case ".wav":
                    return constants.WAV;

                case ".docx":
                    return constants.DOCX;

                case ".zip":
                    return constants.ZIP;



                default:
                    return constants.FILE;


            }

  
        }


        public static string searchFile(string path)
        {
            string[] files = Directory.GetFiles(path);
            string file = string.Empty;
            foreach (var f in files)
            {
                if (f.Contains("Google.Apis.Auth.OAuth2.Responses"))
                {
                    try
                    {
                         file = System.IO.Path.GetFileName(f).ToString();
                    } catch
                    {

                    }
                  
                }

            }

            return file;
        
        }


        public static string[] searchFolder(string path)
        {
            string[] files = Directory.GetDirectories(path);
            return files;
        }

        public static bool checkTokenResponse()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\" + misc.searchFile(Environment.CurrentDirectory)))
            {
                return true;
            }

            return false;
        }

        public static bool checkUserTokenDirectory()
        {
            if (System.IO.Directory.Exists(Environment.CurrentDirectory + @"\Users\" + constants.email))
            {
                return true;
            }

            return false;
        }

        public static bool checkUserTokenFile()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\Users\" + constants.email + @"\" + misc.searchFile(Environment.CurrentDirectory)))
            {
                return true;
            }

            return false;
        }

        public static bool checkSettings()
        {
            if (constants.clientId == string.Empty || constants.clientSecret == string .Empty)
            {
                return false;
            }

            return true;
        }
     


    }
}
