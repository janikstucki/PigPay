using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class EBankingForm : Form
  {
    //public string EingeloggteKontonummer { get; private set; }
    private string EingeloggteKontonummer;
    private double EingeloggterKontostand;


    public EBankingForm(string EKontonummer, string KontoStand)
    {
      InitializeComponent();
      EingeloggteKontonummer = EKontonummer;
      EingeloggterKontostand = Convert.ToDouble(KontoStand);
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

          //Überprüft ob die Geld Sendenadresse in eine Variable konventiert werden konnte.
          if (!int.TryParse(GeldSendenAnTBX.Text, out int zielKontonummer))
          {
            MessageBox.Show("Bitte geben Sie eine gültige Kontonummer ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          //Überprüft ob der betrag grösser als 0 ist.
          if (!double.TryParse(GeldSendenBetragTBX.Text, out double betrag) || betrag <= 0)
          {
            MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          //Überprüft ob die Sendeadresse eine andre als die eingeloggte ist.
          if (GeldSendenAnTBX.Text == EingeloggteKontonummer)
          {
            MessageBox.Show("Fehler bei der Transaktion! Sie können sich nicht selbst Geld senden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          //Überprüft ob der Betrag überhaupt auf den eingeloggten Konto vorhanden ist.
          if (EingeloggterKontostand < betrag)
          {
            MessageBox.Show("Fehler bei der Transaktion! Saldo zu klein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          // Transaktion starten
          OleDbTransaction transaction = connection.BeginTransaction();

          try
          {
            // Betrag vom eingeloggten Konto abziehen
            string updateQuery1 = "UPDATE BenutzerInformationen SET Guthaben = Guthaben - @Betrag WHERE Kontonummer = @EingeloggteKontonummer";

            using (OleDbCommand cmd = new OleDbCommand(updateQuery1, connection, transaction))
            {
              cmd.Parameters.AddWithValue("@Betrag", betrag);
              cmd.Parameters.AddWithValue("@EingeloggteKontonummer", EingeloggteKontonummer);

              int rowsAffected = cmd.ExecuteNonQuery();

              if (rowsAffected <= 0)
              {
                MessageBox.Show("Fehler beim Abziehen des Betrags vom eingeloggten Konto.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              }
            }

            // Betrag zum Zielkonto hinzufügen
            string query = "UPDATE BenutzerInformationen SET Guthaben = Guthaben + @Betrag WHERE Kontonummer = @ZielKontonummer";

            using (OleDbCommand cmd = new OleDbCommand(query, connection, transaction))
            {
              cmd.Parameters.AddWithValue("@Betrag", betrag);
              cmd.Parameters.AddWithValue("@ZielKontonummer", zielKontonummer);

              int rowsAffected = cmd.ExecuteNonQuery();
              if (rowsAffected <= 0)
              {
                MessageBox.Show("Fehler beim Hinzufügen des Betrags zum Zielkonto.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              }



              string LastTransactionSenden = "INSERT INTO Buchung(fk_Id, to_acc, Betrag) VALUES(@EK, @ZielKontonummer, @Betrag)";

              using (OleDbCommand cmd2 = new OleDbCommand(LastTransactionSenden, connection, transaction))
              {
                // Add parameters to the command
                cmd2.Parameters.AddWithValue("@EK", EingeloggteKontonummer);
                cmd2.Parameters.AddWithValue("@ZielKontonummer", zielKontonummer);
                cmd2.Parameters.AddWithValue("@Betrag", betrag);

                try
                {
                  // Execute the command
                  int rowsAffectedLST = cmd2.ExecuteNonQuery();

                  // Check the result
                  if (rowsAffected > 0)
                  {
                    Console.WriteLine("Insert successful.");
                  }
                  else
                  {
                    Console.WriteLine("No rows inserted.");
                  }
                }
                catch (Exception ex)
                {
                  MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

              }

              //string LastTransactionSenden = "UPDATE Buchung SET fk_Id = @EK and to_acc = @ZielKontonummer and Betrag = @Betrag";
              //insert into Fahrzeug(Marke, Typ, NeuPreis, Jahrgang, Occasion)
              //values('Renault', 'Talisman', 45000.00, 2017, 0)



              // Transaktion abschließen
              transaction.Commit();
              MessageBox.Show("Überweisung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

    private void OnHomeClick(object sender, EventArgs e)
    {
      HomeForm homeFrom = new HomeForm(EingeloggteKontonummer);
      homeFrom.Show();
      this.Close();
    }

    private void EBankingForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (DialogResult != DialogResult.OK)
      Application.Exit();
    }
  }
}
