namespace PigPayV01
{
  partial class EBankingForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.GreetLBL = new System.Windows.Forms.Label();
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eBankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GeldSendenAnTBX = new System.Windows.Forms.TextBox();
      this.GeldSendenBetragTBX = new System.Windows.Forms.TextBox();
      this.ueberweisenBTN = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.MainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // GreetLBL
      // 
      this.GreetLBL.AutoSize = true;
      this.GreetLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GreetLBL.Location = new System.Drawing.Point(375, 7);
      this.GreetLBL.Name = "GreetLBL";
      this.GreetLBL.Size = new System.Drawing.Size(103, 25);
      this.GreetLBL.TabIndex = 3;
      this.GreetLBL.Text = "E-Banking";
      // 
      // MainMenu
      // 
      this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.eBankingToolStripMenuItem,
            this.hilfeToolStripMenuItem});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.MainMenu.Size = new System.Drawing.Size(872, 28);
      this.MainMenu.TabIndex = 2;
      this.MainMenu.Text = "menuStrip1";
      // 
      // homeToolStripMenuItem
      // 
      this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
      this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.homeToolStripMenuItem.Text = "Home";
      this.homeToolStripMenuItem.Click += new System.EventHandler(this.OnHomeClick);
      // 
      // eBankingToolStripMenuItem
      // 
      this.eBankingToolStripMenuItem.Name = "eBankingToolStripMenuItem";
      this.eBankingToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
      this.eBankingToolStripMenuItem.Text = "E-Banking";
      // 
      // hilfeToolStripMenuItem
      // 
      this.hilfeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
      this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
      this.hilfeToolStripMenuItem.Text = "Hilfe";
      // 
      // GeldSendenAnTBX
      // 
      this.GeldSendenAnTBX.Location = new System.Drawing.Point(66, 136);
      this.GeldSendenAnTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.GeldSendenAnTBX.Name = "GeldSendenAnTBX";
      this.GeldSendenAnTBX.Size = new System.Drawing.Size(112, 22);
      this.GeldSendenAnTBX.TabIndex = 4;
      this.GeldSendenAnTBX.Text = "Kontonummer";
      // 
      // GeldSendenBetragTBX
      // 
      this.GeldSendenBetragTBX.Location = new System.Drawing.Point(232, 136);
      this.GeldSendenBetragTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.GeldSendenBetragTBX.Name = "GeldSendenBetragTBX";
      this.GeldSendenBetragTBX.Size = new System.Drawing.Size(89, 22);
      this.GeldSendenBetragTBX.TabIndex = 5;
      this.GeldSendenBetragTBX.Text = "Betrag";
      // 
      // ueberweisenBTN
      // 
      this.ueberweisenBTN.Location = new System.Drawing.Point(113, 200);
      this.ueberweisenBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ueberweisenBTN.Name = "ueberweisenBTN";
      this.ueberweisenBTN.Size = new System.Drawing.Size(140, 36);
      this.ueberweisenBTN.TabIndex = 6;
      this.ueberweisenBTN.Text = "Geld senden";
      this.ueberweisenBTN.UseVisualStyleBackColor = true;
      this.ueberweisenBTN.Click += new System.EventHandler(this.ueberweisenBTN_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(494, 136);
      this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
      this.dateTimePicker1.TabIndex = 7;
      // 
      // EBankingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(872, 494);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.ueberweisenBTN);
      this.Controls.Add(this.GeldSendenBetragTBX);
      this.Controls.Add(this.GeldSendenAnTBX);
      this.Controls.Add(this.GreetLBL);
      this.Controls.Add(this.MainMenu);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "EBankingForm";
      this.Text = "E-Banking";
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label GreetLBL;
    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eBankingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    private System.Windows.Forms.TextBox GeldSendenAnTBX;
    private System.Windows.Forms.TextBox GeldSendenBetragTBX;
    private System.Windows.Forms.Button ueberweisenBTN;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
  }
}