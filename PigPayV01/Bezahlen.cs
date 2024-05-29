using System;
using System.Data.OleDb;
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

        using (OleDbConnection connection = new OleDbConnection(Program.ConnectStringBuilder.ConnectionString))
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

          OleDbTransaction transaction = connection.BeginTransaction();

          try
          {
            // Kontostand aktualisieren
            string updateQuery = "UPDATE BenutzerInformationen SET Guthaben = Guthaben + @Betrag WHERE Kontonummer = @AccNummer";
            //Geld abziehen
            //string updateQuery2 = "UPDATE BenutzerInformationen SET Guthaben = Guthaben - @Betrag WHERE Kontonummer != @AccNummer";

            using (OleDbCommand cmd = new OleDbCommand(updateQuery, connection, transaction))
            {
              cmd.Parameters.AddWithValue("@Betrag", betrag);
              cmd.Parameters.AddWithValue("@AccNummer", kontonummer);

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

            transaction.Commit();
          }
          catch (Exception ex)
          {
            transaction.Rollback();
            MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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