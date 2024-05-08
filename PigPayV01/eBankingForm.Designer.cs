namespace PigPayV01
{
  partial class eBankingForm
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
      this.HilfeMainMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.UhrLBL = new System.Windows.Forms.Label();
      this.MainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainMenu
      // 
      this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HilfeMainMenu});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Size = new System.Drawing.Size(800, 28);
      this.MainMenu.TabIndex = 1;
      this.MainMenu.Text = "menuStrip1";
      // 
      // HilfeMainMenu
      // 
      this.HilfeMainMenu.Name = "HilfeMainMenu";
      this.HilfeMainMenu.Size = new System.Drawing.Size(55, 24);
      this.HilfeMainMenu.Text = "Hilfe";
      // 
      // UhrLBL
      // 
      this.UhrLBL.AutoSize = true;
      this.UhrLBL.Location = new System.Drawing.Point(760, 28);
      this.UhrLBL.Name = "UhrLBL";
      this.UhrLBL.Size = new System.Drawing.Size(28, 16);
      this.UhrLBL.TabIndex = 2;
      this.UhrLBL.Text = "Uhr";
      this.UhrLBL.Click += new System.EventHandler(this.UhrLBL_Click);
      // 
      // eBankingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.UhrLBL);
      this.Controls.Add(this.MainMenu);
      this.Name = "eBankingForm";
      this.Text = "eBankingForm";
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem HilfeMainMenu;
    private System.Windows.Forms.Label UhrLBL;
  }
}