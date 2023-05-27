// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        string folderPath = @"C:\path\to\folder";

        try
        {
            string[] fileNames = Directory.GetFiles(folderPath);

            Array.Sort(fileNames); // Dosya isimlerini sırala

            for (int i = 0; i < fileNames.Length; i++)
            {

                //Console.WriteLine(Path.GetFileName(fileNames[i]));
                string fileName = fileNames[i];
                string newFileName = Path.Combine(Path.GetDirectoryName(fileName), (i + 10) + ". " + Path.GetFileName(fileName));
                File.Move(fileName, newFileName);
                Console.WriteLine("Dosya adı güncellendi: " + newFileName);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.ResetColor();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Hata oluştu: " + e.Message);
        }

        Console.ReadKey();
    }
}
