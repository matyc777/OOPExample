using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace OOPExample
{
    class TextFileOutput : IOutput
    {
        void IOutput.Write(List<string> Text)
        {
            FileStream fileStream = new FileStream("Figures.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(fileStream, Encoding.Unicode);
            foreach (string str in Text)
            {
                write.WriteLine(str);
            }
            write.Close();
            fileStream.Close();
            Process.Start("Figures.txt");
        }
    }
}
