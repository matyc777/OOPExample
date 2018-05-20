using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPExample
{
    class FileOutput
    {
        static public void WriteFile(List<string> Text)
        {
            FileStream File = new FileStream("Figures.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(File, Encoding.Unicode);
            foreach (string str in Text)
            {
                write.WriteLine(str);
            }
            write.Close();
            File.Close();
        }
    }
}
