using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Utilities;

namespace ServiceReceiverMedia.Service
{
    public static class FileService
    {
        public static async Task<string> SaveFile(IFormFile file, string folder, string fullFileName)
        {
            try
            {
                try
                {
                    File.Delete(folder + "\\" + fullFileName);
                }
                catch { }
                var full_file_path = folder + "\\" + fullFileName;
                using (Stream fileStream = new FileStream(full_file_path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                /*
                using (FileStream file_local = System.IO.File.OpenWrite(full_file_path))
                {
                    file.CopyTo(file_local);
                }
                */
                return full_file_path;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("UploadFile - FileService: " + ex);
            }
            return null;
        }

        public static string CheckAndCreateFolder(string root, List<string> childFolderByOrder)
        {
            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var path = currentDirectory+"\\"+ root;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if(childFolderByOrder!=null && childFolderByOrder.Count > 0)
                {
                    foreach (var child in childFolderByOrder)
                    {
                        path = path + "\\" + child;
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                    }
                }
                return path;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("CheckAndCreateFolder - FileService: " + ex);
            }
            return root;
        }
        public static string BuildURLFromPath(string path)
        {
            var result = path;
            var currentDirectory = Directory.GetCurrentDirectory();
            result = result.Replace(currentDirectory, "").Replace(@"\\", @"\").Replace(@"\", "/");
            return result;
        }
        public static bool IsBase64String(string s)
        {
            try
            {
                byte[] bytes = System.Convert.FromBase64String(s);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
