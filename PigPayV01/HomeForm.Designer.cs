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
      this.eBankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GreetLBL = new System.Windows.Forms.Label();
      this.MainMenu.SuspendLayout();
      this.SuspendLayout();
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
      this.MainMenu.Size = new System.Drawing.Size(907, 28);
      this.MainMenu.TabIndex = 0;
      this.MainMenu.Text = "menuStrip1";
      // 
      // homeToolStripMenuItem
      // 
      this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
      this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.homeToolStripMenuItem.Text = "Home";
      // 
      // eBankingToolStripMenuItem
      // 
      this.eBankingToolStripMenuItem.Name = "eBankingToolStripMenuItem";
      this.eBankingToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
      this.eBankingToolStripMenuItem.Text = "E-Banking";
      this.eBankingToolStripMenuItem.Click += new System.EventHandler(this.OnEBankingClick);
      // 
      // hilfeToolStripMenuItem
      // 
      this.hilfeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
      this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
      this.hilfeToolStripMenuItem.Text = "Hilfe";
      // 
      // GreetLBL
      // 
      this.GreetLBL.AutoSize = true;
      this.GreetLBL.BackColor = System.Drawing.SystemColors.Control;
      this.GreetLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GreetLBL.Location = new System.Drawing.Point(387, 6);
      this.GreetLBL.Name = "GreetLBL";
      this.GreetLBL.Size = new System.Drawing.Size(105, 25);
      this.GreetLBL.TabIndex = 1;
      this.GreetLBL.Text = "Guten Tag";
      // 
      // HomeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(907, 426);
      this.Controls.Add(this.GreetLBL);
      this.Controls.Add(this.MainMenu);
      this.MainMenuStrip = this.MainMenu;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "HomeForm";
      this.Text = "Home - PigPay";
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eBankingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    private System.Windows.Forms.Label GreetLBL;
  }
}