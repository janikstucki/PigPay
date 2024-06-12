using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
    
    //public static SqlConnectionStringBuilder ConnectString = new SqlConnectionStringBuilder
    //{
    //  DataSource = "W11-WORK23\\SQLEXPRESS", // Ändern!!!  W11-WORK23\\SQLEXPRESS    NOTEBOOK-JANIK\\SQLEXPRESS
    //  InitialCatalog = "PigPayData",
    //  IntegratedSecurity = true,
    //  TrustServerCertificate = true
    //};
    
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
        string ProgramKontonummer = loginForm.kontonummer;
        Application.Run(new HomeForm(ProgramKontonummer));
      }
    }
  }
}
