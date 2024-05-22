using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class LoginForm : Form
  {
    private bool errorMessageShown = false; // Variable, um zu verfolgen, ob die Fehlermeldung bereits angezeigt wurde

    public LoginForm()
    {
      InitializeComponent();
      UsernameTBX.Text = "1234567890";
      PasswortTBX.Text = "Passwort";
    }

    private void OnAnmelden(object sender, EventArgs e)
    {
      try
      {
        SqlConnectionStringBuilder Con = new SqlConnectionStringBuilder
        {
          DataSource = "W11-WORK23\\SQLEXPRESS",
          InitialCatalog = "PigPayData",
          IntegratedSecurity = true,
          TrustServerCertificate = true
        };

        using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
        {
          connection.Open();

          string query = "SELECT COUNT(*) FROM BenutzerInformationen WHERE Kontonummer = @Kontonummer AND Passwort = @Passwort";
          using (SqlCommand cmd = new SqlCommand(query, connection))
          {
            cmd.Parameters.AddWithValue("@Kontonummer", kontonummer);
            cmd.Parameters.AddWithValue("@Passwort", passwort);

            int userCount = (int)cmd.ExecuteScalar();
            if (userCount == 1)
            {
              this.DialogResult = DialogResult.OK;
            }
            else
            {
              if (!errorMessageShown) // Überprüft, ob die Fehlermeldung bereits angezeigt wurde
              {
                MessageBox.Show("Kontonummer oder Passwort ist falsch.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMessageShown = true; // Setzt den Status der Fehlermeldung auf true, um anzuzeigen, dass die Fehlermeldung angezeigt wurde
              }
              this.DialogResult = DialogResult.None;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.DialogResult = DialogResult.None;
      }
    }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.DialogResult != DialogResult.OK)
      {
        e.Cancel = true;
      }
    }

    private void AnmeldenBTN_Click(object sender, EventArgs e)
    {
      OnAnmelden(sender, e);
    }
  }
}
