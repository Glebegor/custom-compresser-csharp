

namespace customcompress;

public class Decompresser
{
    private string _compressedFilePath;
    private string _decompressedFilePath;
    
    public Decompresser()
    {
        _compressedFilePath = String.Empty;
        _decompressedFilePath = String.Empty;
    }
    
    public void GetFile(string compressedFilePath)
    {
        _compressedFilePath = compressedFilePath;
    }
    
    public bool DecompressFile()
    {
        
        return true;
    }
    
    public bool CreateDecompressedFile()
    {
        
        return true;
    }
}