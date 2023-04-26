using System;
using System.Windows.Forms;

namespace FredLogViewer
{
  internal static class Program
  {
    /// <summary>
    /// Point d'entrée principale de l'application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMain());
    }
  }
}
