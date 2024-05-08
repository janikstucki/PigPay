using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    // Überprüft ob die eingegebenenDaten in der Datenbank vorhanden sind um sich Anzumelden
    private void OnAnmelden(object sender, EventArgs e)
    {
      this.Close();
    }
    /* Holt sich die Daten aus der Datenbank und überprüft ob die eingegebenen Daten stimmen falls nicht gibt es eine 
    Fehlermeldung aus*/
    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
      if(DialogResult != DialogResult.OK) return;
      const String connectionString = @"Data Source=W11-WORK23\SQLEXPRESS;Initial Catalog=PigPayData;Integrated Security=True;";
      var query = "SELECT * FROM BenutzerInformationen";
      string Benutzername = UsernameTBX.Text;
      List<int> b = new List<int>();
      string Passwort = PasswortTBX.Text;
      string p = string.Empty;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand(query, connection);

        connection.Open();

        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
          b.Add(reader.GetInt32(reader.GetOrdinal("Kontonummer")));
        }
        connection.Close();
        foreach (int s in b)
        {
          if (s.ToString() == UsernameTBX.Text)
          {
            
            query = "SELECT * FROM BenutzerInformationen WHERE Kontonummer = @Value1";
            SqlCommand sql = new SqlCommand(query, connection);
            sql.Parameters.AddWithValue("@Value1", UsernameTBX.Text);
            connection.Open();

            reader = sql.ExecuteReader();
            while (reader.Read())
            {
              p = reader.GetString(reader.GetOrdinal("passwort"));
            }
            if (p != PasswortTBX.Text)
            {
              e.Cancel = true;
              MessageBox.Show("Eingabe Falsch", "Fehler",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

          }
          else
          {
            e.Cancel = true;
            MessageBox.Show("Eingabe Falsch", "Chipsi ist sauer");
          }
        }

        reader.Close();
        connection.Close();

      }
    }
  }
}
