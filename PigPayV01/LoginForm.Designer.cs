namespace PigPayV01
{
  partial class LoginForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.PasswortShowCHBX = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // UsernameTBX
      // 
      this.UsernameTBX.Location = new System.Drawing.Point(489, 366);
      this.UsernameTBX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.UsernameTBX.Name = "UsernameTBX";
      this.UsernameTBX.Size = new System.Drawing.Size(217, 26);
      this.UsernameTBX.TabIndex = 0;
      // 
      // PasswortTBX
      // 
      this.PasswortTBX.Location = new System.Drawing.Point(489, 401);
      this.PasswortTBX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.PasswortTBX.Name = "PasswortTBX";
      this.PasswortTBX.Size = new System.Drawing.Size(217, 26);
      this.PasswortTBX.TabIndex = 1;
      this.PasswortTBX.UseSystemPasswordChar = true;
      // 
      // AnmeldenBTN
      // 
      this.AnmeldenBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.AnmeldenBTN.Location = new System.Drawing.Point(580, 480);
      this.AnmeldenBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.AnmeldenBTN.Name = "AnmeldenBTN";
      this.AnmeldenBTN.Size = new System.Drawing.Size(98, 29);
      this.AnmeldenBTN.TabIndex = 2;
      this.AnmeldenBTN.Text = "Anmelden";
      this.AnmeldenBTN.UseVisualStyleBackColor = true;
      this.AnmeldenBTN.Click += new System.EventHandler(this.AnmeldenBTN_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightPink;
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(324, 808);
      this.panel1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.BackgroundImage = global::PigPayV01.Properties.Resources.LogoKleiner_removebg_preview;
      this.panel2.Location = new System.Drawing.Point(3, 183);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(368, 369);
      this.panel2.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(83, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 46);
      this.label2.TabIndex = 1;
      this.label2.Text = "Login";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(54, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(190, 59);
      this.label1.TabIndex = 0;
      this.label1.Text = "PigPay";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(331, 366);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(164, 29);
      this.label3.TabIndex = 4;
      this.label3.Text = "Kontonummer";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(361, 398);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(112, 29);
      this.label4.TabIndex = 5;
      this.label4.Text = "Passwort";
      // 
      // PasswortShowCHBX
      // 
      this.PasswortShowCHBX.AutoSize = true;
      this.PasswortShowCHBX.Location = new System.Drawing.Point(489, 436);
      this.PasswortShowCHBX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.PasswortShowCHBX.Name = "PasswortShowCHBX";
      this.PasswortShowCHBX.Size = new System.Drawing.Size(151, 24);
      this.PasswortShowCHBX.TabIndex = 8;
      this.PasswortShowCHBX.Text = "Passwort zeigen";
      this.PasswortShowCHBX.UseVisualStyleBackColor = true;
      this.PasswortShowCHBX.CheckedChanged += new System.EventHandler(this.PasswortShowCHBX_CheckedChanged);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(878, 808);
      this.Controls.Add(this.PasswortShowCHBX);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.AnmeldenBTN);
      this.Controls.Add(this.PasswortTBX);
      this.Controls.Add(this.UsernameTBX);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "LoginForm";
      this.Text = "Login - PigPay";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox UsernameTBX;
    private System.Windows.Forms.TextBox PasswortTBX;
    private System.Windows.Forms.Button AnmeldenBTN;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox PasswortShowCHBX;
    private System.Windows.Forms.Panel panel2;
  }
}

