namespace EasySetup
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      Caption = new Label();
      HeaderPanel = new Panel();
      GameLaunchers = new CheckedListBox();
      label1 = new Label();
      label2 = new Label();
      Utils = new CheckedListBox();
      label3 = new Label();
      Coding = new CheckedListBox();
      ConfirmButton = new Button();
      HeaderPanel.SuspendLayout();
      SuspendLayout();
      // 
      // Caption
      // 
      Caption.AutoSize = true;
      Caption.CausesValidation = false;
      Caption.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
      Caption.ForeColor = SystemColors.ControlLightLight;
      Caption.Location = new Point(100, 7);
      Caption.Name = "Caption";
      Caption.Padding = new Padding(0, 4, 0, 0);
      Caption.RightToLeft = RightToLeft.No;
      Caption.Size = new Size(351, 40);
      Caption.TabIndex = 0;
      Caption.Text = "Easy Setup by ImLewel";
      Caption.TextAlign = ContentAlignment.MiddleCenter;
      Caption.Click += Caption_Click;
      // 
      // HeaderPanel
      // 
      HeaderPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      HeaderPanel.BackColor = SystemColors.ControlText;
      HeaderPanel.BorderStyle = BorderStyle.Fixed3D;
      HeaderPanel.Controls.Add(Caption);
      HeaderPanel.Dock = DockStyle.Top;
      HeaderPanel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      HeaderPanel.Location = new Point(0, 0);
      HeaderPanel.Name = "HeaderPanel";
      HeaderPanel.Size = new Size(545, 68);
      HeaderPanel.TabIndex = 1;
      // 
      // GameLaunchers
      // 
      GameLaunchers.BackColor = SystemColors.ControlText;
      GameLaunchers.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      GameLaunchers.ForeColor = SystemColors.ControlLightLight;
      GameLaunchers.FormattingEnabled = true;
      GameLaunchers.IntegralHeight = false;
      GameLaunchers.Location = new Point(12, 104);
      GameLaunchers.Name = "GameLaunchers";
      GameLaunchers.Size = new Size(150, 193);
      GameLaunchers.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Consolas", 9F, FontStyle.Underline, GraphicsUnit.Point);
      label1.ForeColor = SystemColors.ControlLightLight;
      label1.Location = new Point(12, 82);
      label1.Margin = new Padding(3, 3, 3, 0);
      label1.Name = "label1";
      label1.Size = new Size(120, 18);
      label1.TabIndex = 3;
      label1.Text = "Game Launchers";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Consolas", 9F, FontStyle.Underline, GraphicsUnit.Point);
      label2.ForeColor = SystemColors.ControlLightLight;
      label2.Location = new Point(192, 82);
      label2.Margin = new Padding(3, 3, 3, 0);
      label2.Name = "label2";
      label2.Size = new Size(48, 18);
      label2.TabIndex = 5;
      label2.Text = "Utils";
      // 
      // Utils
      // 
      Utils.BackColor = SystemColors.ControlText;
      Utils.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      Utils.ForeColor = SystemColors.ControlLightLight;
      Utils.FormattingEnabled = true;
      Utils.IntegralHeight = false;
      Utils.Location = new Point(192, 104);
      Utils.Name = "Utils";
      Utils.Size = new Size(150, 193);
      Utils.TabIndex = 4;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Consolas", 9F, FontStyle.Underline, GraphicsUnit.Point);
      label3.ForeColor = SystemColors.ControlLightLight;
      label3.Location = new Point(374, 82);
      label3.Margin = new Padding(3, 3, 3, 0);
      label3.Name = "label3";
      label3.Size = new Size(56, 18);
      label3.TabIndex = 7;
      label3.Text = "Coding";
      // 
      // Coding
      // 
      Coding.BackColor = SystemColors.ControlText;
      Coding.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      Coding.ForeColor = SystemColors.ControlLightLight;
      Coding.FormattingEnabled = true;
      Coding.IntegralHeight = false;
      Coding.Location = new Point(374, 104);
      Coding.Name = "Coding";
      Coding.Size = new Size(150, 193);
      Coding.TabIndex = 6;
      // 
      // ConfirmButton
      // 
      ConfirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ConfirmButton.BackColor = SystemColors.ActiveCaptionText;
      ConfirmButton.Dock = DockStyle.Bottom;
      ConfirmButton.FlatAppearance.BorderColor = Color.White;
      ConfirmButton.FlatAppearance.BorderSize = 2;
      ConfirmButton.FlatAppearance.MouseOverBackColor = Color.Silver;
      ConfirmButton.FlatStyle = FlatStyle.Flat;
      ConfirmButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
      ConfirmButton.ForeColor = SystemColors.ControlLightLight;
      ConfirmButton.Location = new Point(0, 676);
      ConfirmButton.Margin = new Padding(3, 3, 3, 6);
      ConfirmButton.Name = "ConfirmButton";
      ConfirmButton.Size = new Size(545, 44);
      ConfirmButton.TabIndex = 8;
      ConfirmButton.Text = "Download and setup";
      ConfirmButton.UseVisualStyleBackColor = false;
      ConfirmButton.Click += ConfirmButton_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlText;
      ClientSize = new Size(545, 720);
      Controls.Add(ConfirmButton);
      Controls.Add(label3);
      Controls.Add(Coding);
      Controls.Add(label2);
      Controls.Add(Utils);
      Controls.Add(label1);
      Controls.Add(GameLaunchers);
      Controls.Add(HeaderPanel);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "MainForm";
      Text = "Easy Setup by ImLewel";
      HeaderPanel.ResumeLayout(false);
      HeaderPanel.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label Caption;
    private Panel HeaderPanel;
    private CheckedListBox GameLaunchers;
    private Label label1;
    private Label label2;
    private CheckedListBox Utils;
    private Label label3;
    private CheckedListBox Coding;
    private Button ConfirmButton;
  }
}