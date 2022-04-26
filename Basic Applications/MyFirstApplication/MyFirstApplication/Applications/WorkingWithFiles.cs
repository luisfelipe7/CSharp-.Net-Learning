using System;
using System.IO;
using Microsoft.VisualBasic;

namespace MyFirstApplication.Applications
{
  public class WorkingWithFiles
  {
    static void Main(string[] args)
    {

      // Using File and FileInfo

      // Just use this if you don't need to perform a lot of operations
      var path = @"c:\somefile.jpg";
      File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
      File.Delete(path);
      if (File.Exists(path)) {

      }
      var content = File.ReadAllText(path);


      var fileInfo = new FileInfo(path);
      fileInfo.CopyTo("...");
      fileInfo.Delete();
      if (fileInfo.Exists) {

      }


      // Using Directory and DirectoryInfo

      Directory.CreateDirectory(@"c:\temp\folder1");

      var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

      foreach (var file in files) {
        Console.WriteLine(file);
      }

      var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
      foreach (var directory in directories) {
        Console.WriteLine(directory);
      }

      Directory.Exists("...");

      var directoryInfo = new DirectoryInfo("...");
      directoryInfo.GetFiles();
      directoryInfo.GetDirectories();

      // Using Path Class
      var path2 = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";
      var dotIndex = path2.IndexOf('.');
      var extension = path2.Substring(dotIndex);

      Console.WriteLine("Extension: " + Path.GetExtension(path));
      Console.WriteLine("File Name: " + Path.GetFileName(path));
      Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
      Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));



    }
  }
}
