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
    
    public void getFile(string compressedFilePath)
    {
        _compressedFilePath = compressedFilePath;
    }
    
    public bool decompressFile()
    {
        
        return true;
    }
    
    public bool createDecompressedFile()
    {
        
        return true;
    }
}