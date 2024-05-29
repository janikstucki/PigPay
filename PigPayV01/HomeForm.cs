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
    private string KontoNummer;

    public HomeForm(string HomeKontonummer)
    {
      InitializeComponent();
      this.KontoNummer = HomeKontonummer;
    }

    private void GreetLBL_Click(object sender, EventArgs e)
    {
     GreetLBL.Text = this.KontoNummer;
    }
        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void OnEBankingClick(object sender, EventArgs e)
        {

          EBankingForm bezahlenFrom = new EBankingForm();
          bezahlenFrom.ShowDialog();
          this.Close();


        }
      }
    
  }

