using System;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace contabilidad3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        
    }
}