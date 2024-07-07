

namespace customcompress;

public class Decompresser
{
    private string _compressedFilePath;
    
    public Decompresser()
    {
        _compressedFilePath = String.Empty;
    }
    
    public void GetFile(string compressedFilePath)
    {
        _compressedFilePath = compressedFilePath;
    }
    
    public bool DecompressFile()
    {
        FileStream file = File.OpenRead(_compressedFilePath);
        
        string text = File.ReadAllText(_compressedFilePath);
        
        string decompressedText = String.Empty;
        
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsDigit(text[i]))
            {
                int count = Int32.Parse(text[i].ToString());
                for (int j = 0; j < count; j++)
                {
                    decompressedText += text[i-1];
                }
            }
        }
        
        string nameOfFile = file.Name.Split(".")[0].Split("/")[^1];
        
        Console.WriteLine(decompressedText);
        
        CreateDecompressedFile(decompressedText, nameOfFile + ".txt");
        
        return true;
    }
    
    public bool CreateDecompressedFile(string decompressedText, string name)
    {
        File.WriteAllText(name, decompressedText);
        return true;
    }
}