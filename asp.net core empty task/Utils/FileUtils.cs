using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Utils
{
    public class FileUtils
    {
        public static async Task CopyFile(IFormFile file, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            stream.Close();
        }

        public static async Task<bool> Delete(string filePath)
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            return false;
        }
    }
}
