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
using static System.Collections.Specialized.BitVector32;

namespace PigPayV01
{
  public partial class HomeForm : Form
  {
    private string EingeloggteKontonummer ;
    private string Kontostand = string.Empty;
    private string LetzteTransaktion = string.Empty;
    private string LetzteErhalteneTransaktion = string.Empty;


    public HomeForm(string HomeKontonummer)
    {
      InitializeComponent();
      EingeloggteKontonummer = HomeKontonummer;
      using (OleDbConnection connection = new OleDbConnection(Program.ConnectStringBuilder.ConnectionString))
      {
        string Vorname = string.Empty;
        connection.Open();
        string query = "SELECT Vorname FROM BenutzerInformationen WHERE Kontonummer = @Kontonummer";

        using (OleDbCommand cmd = new OleDbCommand(query, connection))
        {
          cmd.Parameters.AddWithValue("@Kontonummer", EingeloggteKontonummer);

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
          cmd.Parameters.AddWithValue("@Kontonummer", EingeloggteKontonummer);

          using (OleDbDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              Kontostand = reader["Guthaben"].ToString();
            }
          }
        }
        string query3 = "SELECT to_acc, Betrag FROM Buchung WHERE fk_Id = @Kontonummer ORDER BY BuchungId DESC";
        using (OleDbCommand cmd = new OleDbCommand(query3, connection))
        {
          cmd.Parameters.AddWithValue("@Kontonummer", EingeloggteKontonummer);

          using (OleDbDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              string to_acc = reader["to_acc"].ToString();
              string Betrag = reader["Betrag"].ToString();
              LetzteTransaktion = "An " + to_acc + ", " + Betrag + " CHF";
            }
          }
        }

        string query4 = "SELECT fk_Id, Betrag FROM Buchung WHERE to_acc = @Kontonummer ORDER BY BuchungId DESC";
        using (OleDbCommand cmd = new OleDbCommand(query4, connection))
        {
          cmd.Parameters.AddWithValue("@Kontonummer", EingeloggteKontonummer);

          using (OleDbDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              string fk_Id = reader["fk_Id"].ToString();
              string Betrag = reader["Betrag"].ToString();
              LetzteErhalteneTransaktion = "Von " + fk_Id + ", " + Betrag + " CHF";
            }
          }
        }




        GreetLBL.Text = "Guten Tag " + Vorname;
        //string Auswahl = "Guthaben";
        //AktKontostandLBL.Text = SELECT_OLEDB(query2, connection, Auswahl);
        AktKontostandLBL.Text = Kontostand + " CHF";
        LztTransaktionLBL.Text = LetzteTransaktion;
        LztErhaltTransaktionLBL.Text = LetzteErhalteneTransaktion;
      }
    }


    //private void SELECT_OLEDB(string query, OleDbConnection connection, string AuswahlString)
    //{
    //  using (OleDbCommand cmd = new OleDbCommand(query, connection))
    //  {
    //    cmd.Parameters.AddWithValue("@Kontonummer", EingeloggteKontonummer);

    //    using (OleDbDataReader reader = cmd.ExecuteReader())
    //    {
    //      if (reader.Read())
    //      {
    //        string Ausgewaehlt = reader[AuswahlString].ToString();
    //      }
    //    }
    //  }
    //}

    private void GreetLBL_Click(object sender, EventArgs e)
    {
     
    
    }
        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void OnEBankingClick(object sender, EventArgs e)
        {
          EBankingForm bezahlenFrom = new EBankingForm(EingeloggteKontonummer, Kontostand);
          bezahlenFrom.Show();
          this.Hide();
        }

    private void AktKontostandLBL_Click(object sender, EventArgs e)
    {
    }

    private void OnAusloggenClick(object sender, EventArgs e)
    {
      this.Hide();
      LoginForm loginForm = new LoginForm();
      loginForm.ShowDialog();

      if (loginForm.DialogResult == DialogResult.OK)
      {
        EingeloggteKontonummer = loginForm.kontonummer;
        HomeForm homeForm = new HomeForm(EingeloggteKontonummer);
        homeForm.Show();
      }
      else
      {
        Application.Exit();
      }


      //LoginForm loginForm = new LoginForm();
      //loginForm.Show();
      //this.Hide();

      //Form homeForm = ActiveForm;
      ////Form homeForm = ActiveForm;
      //if (loginForm.Visible) { homeForm.Close(); }
    }

    private void OnExitClick(object sender, EventArgs e)
    {
      this.Close();
      
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    

    private void LztTransaktionLBL_Click(object sender, EventArgs e)
    {

    }

    private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void GreetLBL_Click_1(object sender, EventArgs e)
    {

    }

    private void homeToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    
  }
}

