using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class EBankingForm : Form
  {
    public EBankingForm()
    {
      InitializeComponent();
    }

    private void ueberweisenBTN_Click(object sender, EventArgs e)
    {
      try
      {
        // Datenbankverbindung einrichten
        SqlConnectionStringBuilder Con = new SqlConnectionStringBuilder
        {
          DataSource = "W11-WORK23\\SQLEXPRESS", // Ändern entsprechend der Datenbankkonfiguration
          InitialCatalog = "PigPayData",
          IntegratedSecurity = true,
          TrustServerCertificate = true
        };

        using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
        {
          connection.Open();

          // Kontonummer und Betrag aus TextBoxen lesen
          if (!int.TryParse(GeldSendenAnTBX.Text, out int kontonummer))
          {
            MessageBox.Show("Bitte geben Sie eine gültige Kontonummer ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

          if (!double.TryParse(GeldSendenBetragTBX.Text, out double betrag) || betrag <= 0)
          {
            MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

          // Kontostand aktualisieren
          string updateQuery = "UPDATE BenutzerInformationen SET Guthaben = Guthaben + @Betrag WHERE Kontonummer = @Kontonummer";
          using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
          {
            cmd.Parameters.AddWithValue("@Betrag", betrag);
            cmd.Parameters.AddWithValue("@Kontonummer", kontonummer);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
              MessageBox.Show("Überweisung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              MessageBox.Show("Kontonummer nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
