using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigPayV01
{
  internal static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      LoginForm loginForm = new LoginForm();
      loginForm.ShowDialog();
      if (loginForm.DialogResult == DialogResult.OK)
      {
        string PKontonummer = loginForm.kontonummer;
        Application.Run(new HomeForm(PKontonummer));
      }
    }
  }
}
