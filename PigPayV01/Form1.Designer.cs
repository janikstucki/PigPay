namespace PigPayV01
{
  partial class MainForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.UsernameTBX = new System.Windows.Forms.TextBox();
      this.PasswortTBX = new System.Windows.Forms.TextBox();
      this.AnmeldenBTN = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // UsernameTBX
      // 
      this.UsernameTBX.Location = new System.Drawing.Point(362, 276);
      this.UsernameTBX.Name = "UsernameTBX";
      this.UsernameTBX.Size = new System.Drawing.Size(168, 22);
      this.UsernameTBX.TabIndex = 0;
      // 
      // PasswortTBX
      // 
      this.PasswortTBX.Location = new System.Drawing.Point(362, 304);
      this.PasswortTBX.Name = "PasswortTBX";
      this.PasswortTBX.Size = new System.Drawing.Size(168, 22);
      this.PasswortTBX.TabIndex = 1;
      // 
      // AnmeldenBTN
      // 
      this.AnmeldenBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.AnmeldenBTN.Location = new System.Drawing.Point(443, 367);
      this.AnmeldenBTN.Name = "AnmeldenBTN";
      this.AnmeldenBTN.Size = new System.Drawing.Size(87, 23);
      this.AnmeldenBTN.TabIndex = 2;
      this.AnmeldenBTN.Text = "Anmelden";
      this.AnmeldenBTN.UseVisualStyleBackColor = true;
      this.AnmeldenBTN.Click += new System.EventHandler(this.OnAnmelden);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(780, 646);
      this.Controls.Add(this.AnmeldenBTN);
      this.Controls.Add(this.PasswortTBX);
      this.Controls.Add(this.UsernameTBX);
      this.Name = "MainForm";
      this.Text = "PigPay";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox UsernameTBX;
    private System.Windows.Forms.TextBox PasswortTBX;
    private System.Windows.Forms.Button AnmeldenBTN;
  }
}

