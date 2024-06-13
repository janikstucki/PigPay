namespace PigPayV01
{
  partial class HomeForm
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
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AusloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eBankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GreetLBL = new System.Windows.Forms.Label();
      this.AktKontostandLBL = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.LztTransaktionLBL = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.MainMenu.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainMenu
      // 
      this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
      this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.eBankingToolStripMenuItem,
            this.hilfeToolStripMenuItem});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
      this.MainMenu.Size = new System.Drawing.Size(1020, 33);
      this.MainMenu.TabIndex = 0;
      this.MainMenu.Text = "menuStrip1";
      // 
      // homeToolStripMenuItem
      // 
      this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AusloggenToolStripMenuItem,
            this.ExitToolStripMenuItem});
      this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
      this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
      this.homeToolStripMenuItem.Text = "Home";
      // 
      // AusloggenToolStripMenuItem
      // 
      this.AusloggenToolStripMenuItem.Name = "AusloggenToolStripMenuItem";
      this.AusloggenToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
      this.AusloggenToolStripMenuItem.Text = "Ausloggen";
      this.AusloggenToolStripMenuItem.Click += new System.EventHandler(this.OnAusloggenClick);
      // 
      // ExitToolStripMenuItem
      // 
      this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
      this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.ExitToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
      this.ExitToolStripMenuItem.Text = "Exit";
      this.ExitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
      // 
      // eBankingToolStripMenuItem
      // 
      this.eBankingToolStripMenuItem.Name = "eBankingToolStripMenuItem";
      this.eBankingToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
      this.eBankingToolStripMenuItem.Text = "E-Banking";
      this.eBankingToolStripMenuItem.Click += new System.EventHandler(this.OnEBankingClick);
      // 
      // hilfeToolStripMenuItem
      // 
      this.hilfeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
      this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
      this.hilfeToolStripMenuItem.Text = "Hilfe";
      // 
      // GreetLBL
      // 
      this.GreetLBL.AutoSize = true;
      this.GreetLBL.BackColor = System.Drawing.SystemColors.Control;
      this.GreetLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GreetLBL.Location = new System.Drawing.Point(443, 50);
      this.GreetLBL.Name = "GreetLBL";
      this.GreetLBL.Size = new System.Drawing.Size(126, 29);
      this.GreetLBL.TabIndex = 1;
      this.GreetLBL.Text = "Guten Tag";
      // 
      // AktKontostandLBL
      // 
      this.AktKontostandLBL.AutoSize = true;
      this.AktKontostandLBL.Location = new System.Drawing.Point(30, 74);
      this.AktKontostandLBL.Name = "AktKontostandLBL";
      this.AktKontostandLBL.Size = new System.Drawing.Size(157, 20);
      this.AktKontostandLBL.TabIndex = 2;
      this.AktKontostandLBL.Text = "Aktueller Kontostand";
      this.AktKontostandLBL.Click += new System.EventHandler(this.AktKontostandLBL_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.AktKontostandLBL);
      this.panel1.Location = new System.Drawing.Point(34, 80);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(204, 438);
      this.panel1.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(182, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Ihr aktueller Kontostand:";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.panel2.Controls.Add(this.LztTransaktionLBL);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(803, 80);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(204, 438);
      this.panel2.TabIndex = 4;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // LztTransaktionLBL
      // 
      this.LztTransaktionLBL.AutoSize = true;
      this.LztTransaktionLBL.Location = new System.Drawing.Point(30, 74);
      this.LztTransaktionLBL.Name = "LztTransaktionLBL";
      this.LztTransaktionLBL.Size = new System.Drawing.Size(159, 20);
      this.LztTransaktionLBL.TabIndex = 4;
      this.LztTransaktionLBL.Text = "Letzte Transaktionen";
      this.LztTransaktionLBL.Click += new System.EventHandler(this.LztTransaktionLBL_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(30, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(159, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Letzte Transaktionen";
      // 
      // HomeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1020, 532);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.GreetLBL);
      this.Controls.Add(this.MainMenu);
      this.MainMenuStrip = this.MainMenu;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "HomeForm";
      this.Text = "Home - PigPay";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eBankingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    private System.Windows.Forms.Label GreetLBL;
    private System.Windows.Forms.Label AktKontostandLBL;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripMenuItem AusloggenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label LztTransaktionLBL;
  }
}