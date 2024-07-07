namespace customcompress;

public class Compresser
{
    private string _filePath;
    private string _compressedFilePath;
    
    public Compresser()
    {
        _filePath = String.Empty;
        _compressedFilePath = String.Empty;
    }

    public void GetFile(string filePath)
    {
        _filePath = filePath;
    }
    
    public bool CompressFile()
    {
        return true;
    }
    
    public bool CreateCompressedFile()
    {
        return true;
    }
    
}