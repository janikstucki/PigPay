using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class HomeForm : Form
  {
    private string KontoNummer ;

    public HomeForm(string HomeKontonummer)
    {
      InitializeComponent();
      KontoNummer = HomeKontonummer;
      using (OleDbConnection connection = new OleDbConnection(Program.ConnectStringBuilder.ConnectionString))
      {
        string Vorname = string.Empty;
        string Kontostand = string.Empty;
        connection.Open();
        string query = "SELECT Vorname FROM BenutzerInformationen WHERE Kontonummer = @Kontonummer";

        using (OleDbCommand cmd = new OleDbCommand(query, connection))
        {
          cmd.Parameters.AddWithValue("@Kontonummer", KontoNummer);

          using (OleDbDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              Vorname = reader["Vorname"].ToString();
            }
          }
        }
        string query2 = "SELECT Guthaben FROM BenutzerInformationen WHERE Kontonummer = @Kontonummer";
        using (OleDbCommand cmd = new OleDbCommand(query2, connection))
        {
          cmd.Parameters.AddWithValue("@Kontonummer", KontoNummer);

          using (OleDbDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              Kontostand = reader["Guthaben"].ToString();
            }
          }
        }
        GreetLBL.Text = "Guten Tag " + Vorname;
        AktKontostandLBL.Text = Kontostand;
      }
    }
    
    private void GreetLBL_Click(object sender, EventArgs e)
    {
     
    
    }
        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void OnEBankingClick(object sender, EventArgs e)
        {
          EBankingForm bezahlenFrom = new EBankingForm(KontoNummer);
          bezahlenFrom.Show();
          this.Hide();
        }

    private void AktKontostandLBL_Click(object sender, EventArgs e)
    {
    }

    private void OnAusloggenClick(object sender, EventArgs e)
    {
      LoginForm loginForm = new LoginForm();
      loginForm.Show();
      this.Hide();

      //if (loginForm.Visible) { this.Close(); }
    }

    private void OnExitClick(object sender, EventArgs e)
    {
      this.Close();
      
    }
  }
}

