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

    }
    
    private void GreetLBL_Click(object sender, EventArgs e)
    {
      using (OleDbConnection connection = new OleDbConnection(Program.ConnectStringBuilder.ConnectionString))
      {
        string Vorname = string.Empty;
        connection.Open();
        string query = "SELECT Vorname FROM BenutzerInformationen WHERE Kontonummer = @Kontonummer";

        using (OleDbCommand cmd = new OleDbCommand(query, connection))
        {
          cmd.Parameters.AddWithValue("@Kontonummer", KontoNummer);

          using (OleDbDataReader reader = cmd.ExecuteReader())
          {
            if(reader.Read()){
              Vorname = reader["Vorname"].ToString();
            }
          }
        }
        GreetLBL.Text = Vorname;
      }
    
    }
        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void OnEBankingClick(object sender, EventArgs e)
        {

          EBankingForm bezahlenFrom = new EBankingForm();
          bezahlenFrom.Show();
          this.Hide();


        }
      }
    
  }

