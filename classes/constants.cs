

namespace GDrive
{ 
    class constants
    {

        public static string clientId = misc.getSetting("GDrive.ini", 0, 9);
        public static string clientSecret = misc.getSetting("GDrive.ini", 1, 13);
        public static string email = "user@gmail.com";
        public static string avatarLetter = email.Substring(0, 1);
        public static string emailWithoutDomain = email.Replace("@gmail.com", "");
        public static System.Drawing.Bitmap EXE = Properties.Resources.icons8_exe_48px;
        public static System.Drawing.Bitmap AAC = Properties.Resources.icons8_aac_48px;
        public static System.Drawing.Bitmap APK = Properties.Resources.icons8_apk_48px;
        public static System.Drawing.Bitmap AVI = Properties.Resources.icons8_avi_48px;
        public static System.Drawing.Bitmap CSS = Properties.Resources.icons8_css_filetype_48px;
        public static System.Drawing.Bitmap CSV = Properties.Resources.icons8_csv_48px;
        public static System.Drawing.Bitmap FILE = Properties.Resources.icons8_file_48px;
        public static System.Drawing.Bitmap FLV = Properties.Resources.icons8_flv_48px;
        public static System.Drawing.Bitmap GIF = Properties.Resources.icons8_gif_48px;
        public static System.Drawing.Bitmap HTML = Properties.Resources.icons8_html_filetype_48px;
        public static System.Drawing.Bitmap JPG = Properties.Resources.icons8_jpg_48px;
        public static System.Drawing.Bitmap JSON = Properties.Resources.icons8_json_48px;
        public static System.Drawing.Bitmap XLS = Properties.Resources.icons8_xls_48px;
        public static System.Drawing.Bitmap MKV = Properties.Resources.icons8_mkv_48px;
        public static System.Drawing.Bitmap MP3 = Properties.Resources.icons8_mp3_48px;
        public static System.Drawing.Bitmap PDF = Properties.Resources.icons8_pdf_48px;
        public static System.Drawing.Bitmap PNG = Properties.Resources.icons8_png_48px;
        public static System.Drawing.Bitmap PPT = Properties.Resources.icons8_ppt_48px;
        public static System.Drawing.Bitmap RAR = Properties.Resources.icons8_rar_48px;
        public static System.Drawing.Bitmap TAR = Properties.Resources.icons8_tar_48px;
        public static System.Drawing.Bitmap TXT = Properties.Resources.icons8_txt_48px;
        public static System.Drawing.Bitmap MP4 = Properties.Resources.icons8_video_file_48px;
        public static System.Drawing.Bitmap WAV = Properties.Resources.icons8_wav_48px;
        public static System.Drawing.Bitmap DOCX = Properties.Resources.icons8_word_48px;
        public static System.Drawing.Bitmap ZIP = Properties.Resources.icons8_zip_48px;

    }
}
