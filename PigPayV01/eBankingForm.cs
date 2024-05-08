using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigPayV01
{
  public partial class eBankingForm : Form
  {
    public eBankingForm()
    {
      InitializeComponent();
    }

    private void UhrLBL_Click(object sender, EventArgs e)
    {
      DateTime dateTime = DateTime.Now;
      this.UhrLBL.Text = dateTime.ToString();

    }
  }
}
