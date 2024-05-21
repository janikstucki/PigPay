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
  public partial class HomeForm : Form
  {
    public HomeForm()
    {
      InitializeComponent();
    }

    private void GreetLBL_Click(object sender, EventArgs e)
    {
      /*string connectionString = @"Server=NOTEBOOK-JANIK\SQLEXPRESS;Database=BenutzerInformationen;Trusted_Connection=True;";
      string query = "SELECT Vorname, Nachname FROM BenutzerInformationen";
      
      //string VornNachname = 

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        
      }*/
    }
  
    private void HomeForm_Load(object sender, EventArgs e)
    {
      
    }

    private void OnEBankingClick(object sender, EventArgs e)
    {

      EBankingFrom bezahlenFrom = new EBankingFrom();
      bezahlenFrom.ShowDialog();

      this.Close();
    }
  }
}
