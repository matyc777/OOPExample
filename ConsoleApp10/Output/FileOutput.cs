using System.Collections.Generic;
using System.IO;

namespace OOPExample
{
    class FileOutput
    {
        static public void WriteFile(List<string> Text)
        {
            FileStream File = new FileStream("Figures.txt", FileMode.Append, FileAccess.Write);
            StreamWriter write = new StreamWriter(File);
            foreach (string str in Text)
            {
                write.WriteLine(str);
            }
            write.Close();
            File.Close();
        }
    }
}
