using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class EBankingForm : Form
  {
    public string EingelogteKontonummer { get; private set; }

    public EBankingForm()
    {
      InitializeComponent();
    }

    // Methode zum Überweisen von Geld
    private void ueberweisenBTN_Click(object sender, EventArgs e)
    {
      try
      {
        // Datenbankverbindung einrichten
        using (OleDbConnection connection = new OleDbConnection(Program.ConnectStringBuilder.ConnectionString))
        {
          connection.Open();

          // Kontonummer und Betrag aus TextBoxen lesen
          if (!int.TryParse(GeldSendenAnTBX.Text, out int zielKontonummer))
          {
            MessageBox.Show("Bitte geben Sie eine gültige Kontonummer ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

          if (!double.TryParse(GeldSendenBetragTBX.Text, out double betrag) || betrag <= 0)
          {
            MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

          // Transaktion starten
          OleDbTransaction transaction = connection.BeginTransaction();

          try
          {
            // Betrag vom eingeloggten Konto abziehen
            string updateQuery1 = "UPDATE BenutzerInformationen SET Guthaben = Guthaben - @Betrag WHERE Kontonummer = @EingelogteKontonummer";

            using (OleDbCommand cmd = new OleDbCommand(updateQuery1, connection, transaction))
            {
              cmd.Parameters.AddWithValue("@Betrag", betrag);
              cmd.Parameters.AddWithValue("@EingelogteKontonummer", EingelogteKontonummer);

              int rowsAffected = cmd.ExecuteNonQuery();
              if (rowsAffected <= 0)
              {
                MessageBox.Show("Fehler beim Abziehen des Betrags vom eingeloggten Konto.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              }
            }

            // Betrag zum Zielkonto hinzufügen
            string updateQuery2 = "UPDATE BenutzerInformationen SET Guthaben = Guthaben + @Betrag WHERE Kontonummer = @ZielKontonummer";

            using (OleDbCommand cmd = new OleDbCommand(updateQuery2, connection, transaction))
            {
              cmd.Parameters.AddWithValue("@Betrag", betrag);
              cmd.Parameters.AddWithValue("@ZielKontonummer", zielKontonummer);

              int rowsAffected = cmd.ExecuteNonQuery();
              if (rowsAffected <= 0)
              {
                MessageBox.Show("Fehler beim Hinzufügen des Betrags zum Zielkonto.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              }
            }

            // Transaktion abschließen
            transaction.Commit();
            MessageBox.Show("Überweisung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
