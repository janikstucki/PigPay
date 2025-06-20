﻿using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class LoginForm : Form
  {
    public string kontonummer { get; private set; }

    private bool errorMessageShown = false; // Variable, um zu verfolgen, ob die Fehlermeldung bereits angezeigt wurde

    public LoginForm()
    {
      InitializeComponent();
      UsernameTBX.Text = "1234567890";
      PasswortTBX.Text = "Passwort";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void OnAnmelden(object sender, EventArgs e)
    {
      try
      {
        using (OleDbConnection connection = new OleDbConnection(Program.ConnectStringBuilder.ConnectionString))
        {
          connection.Open();

          kontonummer = UsernameTBX.Text;
          string passwort = PasswortTBX.Text;

          string query = "SELECT COUNT(*) FROM BenutzerInformationen WHERE Kontonummer = @Kontonummer AND Passwort = @Passwort";
          using (OleDbCommand cmd = new OleDbCommand(query, connection))
          {
            cmd.Parameters.AddWithValue("@Kontonummer", kontonummer);
            cmd.Parameters.AddWithValue("@Passwort", passwort);

            int userCount = (int)cmd.ExecuteScalar();
            this.DialogResult = DialogResult.None;

            if (userCount == 1)
            {
              this.DialogResult = DialogResult.OK;
              this.Hide();
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
      else
      {
        Application.Exit();
      }
    }

    private void AnmeldenBTN_Click(object sender, EventArgs e)
    {
      OnAnmelden(sender, e);
    }

    private void PasswortShowBTN_Click(object sender, EventArgs e)
    {

    }

    private void PasswortShowCHBX_CheckedChanged(object sender, EventArgs e)
    {
      PasswortTBX.UseSystemPasswordChar = !PasswortTBX.UseSystemPasswordChar;
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }
  }
}
