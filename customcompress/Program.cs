
using customcompress;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start of working!");
        
        Compresser compresser = new Compresser();
        Decompresser decompresser = new Decompresser();

        string chooice = Console.ReadLine();

        switch (chooice)
        {
            case "1":
                string filePath1 = Console.ReadLine();
                compresser.GetFile(filePath1);
                compresser.CompressFile();
                break;
            
            case "2":
                string filePath2 = Console.ReadLine();
                decompresser.GetFile(filePath2);
                decompresser.DecompressFile();
                break;
            
            default:
                Console.WriteLine("Wrong chooice!");
                break;                
        }
        
    }
}