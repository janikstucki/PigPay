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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.PasswortShowCHBX = new System.Windows.Forms.CheckBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // UsernameTBX
      // 
      this.UsernameTBX.Location = new System.Drawing.Point(435, 293);
      this.UsernameTBX.Name = "UsernameTBX";
      this.UsernameTBX.Size = new System.Drawing.Size(193, 22);
      this.UsernameTBX.TabIndex = 0;
      // 
      // PasswortTBX
      // 
      this.PasswortTBX.Location = new System.Drawing.Point(435, 321);
      this.PasswortTBX.Name = "PasswortTBX";
      this.PasswortTBX.Size = new System.Drawing.Size(193, 22);
      this.PasswortTBX.TabIndex = 1;
      this.PasswortTBX.UseSystemPasswordChar = true;
      // 
      // AnmeldenBTN
      // 
      this.AnmeldenBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.AnmeldenBTN.Location = new System.Drawing.Point(516, 384);
      this.AnmeldenBTN.Name = "AnmeldenBTN";
      this.AnmeldenBTN.Size = new System.Drawing.Size(87, 23);
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
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(288, 646);
      this.panel1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(74, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 38);
      this.label2.TabIndex = 1;
      this.label2.Text = "Login";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(48, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 51);
      this.label1.TabIndex = 0;
      this.label1.Text = "PigPay";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(294, 293);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(135, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = "Kontonummer";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(321, 318);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(92, 25);
      this.label4.TabIndex = 5;
      this.label4.Text = "Passwort";
      // 
      // PasswortShowCHBX
      // 
      this.PasswortShowCHBX.AutoSize = true;
      this.PasswortShowCHBX.Location = new System.Drawing.Point(435, 349);
      this.PasswortShowCHBX.Name = "PasswortShowCHBX";
      this.PasswortShowCHBX.Size = new System.Drawing.Size(127, 20);
      this.PasswortShowCHBX.TabIndex = 8;
      this.PasswortShowCHBX.Text = "Passwort zeigen";
      this.PasswortShowCHBX.UseVisualStyleBackColor = true;
      this.PasswortShowCHBX.CheckedChanged += new System.EventHandler(this.PasswortShowCHBX_CheckedChanged);
      // 
      // panel2
      // 
      this.panel2.BackgroundImage = global::PigPayV01.Properties.Resources.LogoKleiner_removebg_preview;
      this.panel2.Location = new System.Drawing.Point(3, 145);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(327, 295);
      this.panel2.TabIndex = 2;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(780, 646);
      this.Controls.Add(this.PasswortShowCHBX);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.AnmeldenBTN);
      this.Controls.Add(this.PasswortTBX);
      this.Controls.Add(this.UsernameTBX);
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

