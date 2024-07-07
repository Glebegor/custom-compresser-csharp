using System.IO;

namespace customcompress;

public class Compresser
{
    private string _filePath;
    
    public Compresser()
    {
        _filePath = String.Empty;
    }

    public void GetFile(string filePath)
    {
        _filePath = filePath;
    }
    
    public bool CompressFile()
    {
        FileStream file = File.OpenRead(_filePath);
        
        string text = File.ReadAllText(_filePath);
        string compressedText = String.Empty;
        
        int count_of_number = 1;
        for (int i = 0; i < text.Length-1; i++)
        {
            if (text[i] == text[i + 1])
            {
                count_of_number++;
            }
            else
            {
                compressedText += text[i] + "-" + count_of_number.ToString() + ",";
                count_of_number = 1;
            }
        }
        string nameOfFile = file.Name.Split(".")[0].Split("/")[^1];
                
        Console.WriteLine(compressedText);
        Console.WriteLine(nameOfFile);
        
        CreateCompressedFile(compressedText, nameOfFile + ".hlibzip");
        
        return true;
    }
    
    public bool CreateCompressedFile(string compressedString, string name)
    {
        File.WriteAllText(name, compressedString);
        return true;
    }

    public void Info()
    {
        Console.WriteLine("Information about compressed file.");
    }
}