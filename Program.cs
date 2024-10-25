using System.IO.Compression;
using System.Net;
using System.IO;
using System;
namespace BetterSeliwareLauncher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SeliwareLauncher());
        }
    }
}


public class FolderCreator()
{
    public void Main()
    {
        string folderPath = @"%appdata%\Local\";
        CreateFolder("%appdata%\\Local\\Seliware Launcher");
    }

    public void CreateFolder(string path)
    {
        try
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                return;
            }
        }
        catch (Exception ex)
        {
            return;
        }
    }
}
public class Downloader
{
    public void Main()
    {
        string directoryPath = @"%appdata%\Local\Seliware Launcher";
        string repoUrl = "https://drive.google.com/file/d/1Z0fY3T8EqQiuu5N9lPmAlxwp04mlPL2U/view?usp=sharing";
        string zipPath = @"%Temp%\LauncherData.zip";
        string extractPath = @"%appdata%\Local\Seliware Launcher";
        CheckAndDownloadDirectory(directoryPath, repoUrl, zipPath, extractPath);

    }

    public void CheckAndDownloadDirectory(string directoryPath, string repoUrl, string zipPath, string extractPath)
    {
        
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine("UIs not found.Downloading...");

            try
            {
                
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(repoUrl, zipPath);
                }

                
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Console.WriteLine("All done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading UIs");
            }
            finally
            {
                
                if (File.Exists(zipPath))
                {
                    File.Delete(zipPath);
                }
            }
        }
        else
        {
            Console.WriteLine("UIs already downloaded");
        }
    }
}
