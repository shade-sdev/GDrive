using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Threading;

namespace GDrive
{
    class googledriveapi
    {

        public DriveService service;

        public DriveService  Authorize()
        {
            string[] scopes = new string[] { DriveService.Scope.Drive,
                               DriveService.Scope.DriveFile,};
            var clientId = constants.clientId;
            var clientSecret = constants.clientSecret; 
            
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            }, scopes,
            Environment.UserName, CancellationToken.None, new FileDataStore(Environment.CurrentDirectory, true)).Result;
         
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Shade Driver Uploader",

            });
            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);
    

            return service;

          
        }

        public IList<File> getDriveFiles(DriveService service, string query, string order)
        {
           
            FilesResource.ListRequest FileListRequest = service.Files.List();
            FileListRequest.Q = query;
            FileListRequest.OrderBy = order;
            //listRequest.PageSize = 10;
            //listRequest.PageToken = 10;
            FileListRequest.Fields = "nextPageToken, files(id, name, webViewLink, size, fileExtension, createdTime)";

            IList<Google.Apis.Drive.v3.Data.File> files = FileListRequest.Execute().Files;

            return files;
        }

        public void deleteFile(DriveService service, string fileId)
        {
            service.Files.Delete(fileId).Execute();
        }

        public FilesResource.CreateMediaUpload uploadFile(DriveService _service, string _uploadFile, string _parent, string _descrp = "Uploaded with .NET!")
        {
            if (System.IO.File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = System.IO.Path.GetFileName(_uploadFile);
       
                body.Description = _descrp;
                body.MimeType = GetMimeType(_uploadFile);
                // body.Parents = new List<string> { _parent };// UN comment if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, GetMimeType(_uploadFile));
                    request.Fields = "";
               

                    return request;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message, "Error Occured");
                    return null;
                }
            }
            else
            {

                Console.WriteLine("The file does not exist.", "404");
                return null;
            }
        }


        public static string GetMimeType(string fileName) { 
            string mimeType = "application/unknown"; 
            string ext = System.IO.Path.GetExtension(fileName).ToLower(); 
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext); 
            if (regKey != null && regKey.GetValue("Content Type") != null) 
            mimeType = regKey.GetValue("Content Type").ToString(); 
            System.Diagnostics.Debug.WriteLine(mimeType); 
            return mimeType; }


        public About getUserDriveInfo(DriveService service)
        {
            
                AboutResource.GetRequest getRequest = service.About.Get();
                getRequest.Fields = "*";
                var about = getRequest.Execute();
                return about;

           
        }

        public void filePermission(string type, string fileid)
        {
            Permission perm = new Permission();
            perm.Type = type;
            perm.Role = "writer";
            service.Permissions.Create(perm, fileid).Execute();
        }


    }


    }












