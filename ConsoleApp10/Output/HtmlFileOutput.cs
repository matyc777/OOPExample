using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace OOPExample
{
    class HtmlFileOutput : IOutput
    {
        void IOutput.Write(List<string> Text)
        {
            StreamWriter streamwriter = new StreamWriter(@"Figures.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <title>Figures</title>");
            streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.WriteLine("<center>");
            foreach (string Line in Text)
            {
                streamwriter.WriteLine("<div>" + Line);
            }
            streamwriter.WriteLine("</center>");
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();
            Process.Start("Figures.html");
        }
    }
}
