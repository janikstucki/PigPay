using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PigPayV01
{
  internal static class Program
  {
    public static OleDbConnectionStringBuilder ConnectStringBuilder = new OleDbConnectionStringBuilder
    {
      Provider = "Microsoft.ACE.OLEDB.12.0",
      DataSource = "..\\..\\Datenbank.accdb"
    };

    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      LoginForm loginForm = new LoginForm();
      loginForm.ShowDialog();

      if (loginForm.DialogResult == DialogResult.OK)
      {
        string ProgramKontonummer = loginForm.kontonummer;
        Application.Run(new HomeForm(ProgramKontonummer));
      }
    }
  }
}
