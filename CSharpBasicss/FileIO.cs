using System;
using System.IO;
public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {

        
        string fileContent = File.ReadAllText("fileName");
        Console.WriteLine(fileContent);
        }
        File.WriteAllText(fileName, "This is just a test file");
    }
    public void  LearnFileIndo()
    {
        string fileName = "file.text";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;
        
        Console.WriteLine($"File Size: {size} bytes");
        Console.WriteLine($"Created: {createdDate}");
    }
    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);
    }
    //Q2: Create a folder "ABC", cretae 10 subfolders in "ABC". Each subfolder
    // Should contain a c# file with hello world program

}