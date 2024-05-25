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
      ConfirmButton = new Button();
      FooterPanel = new Panel();
      categoryBox2 = new CategoryBox();
      categoryBox1 = new CategoryBox();
      categoryBox3 = new CategoryBox();
      categoryBox4 = new CategoryBox();
      categoryBox5 = new CategoryBox();
      contentFlowLayoutPanel = new FlowLayoutPanel();
      categoryBox6 = new CategoryBox();
      categoryBox7 = new CategoryBox();
      categoryBox8 = new CategoryBox();
      categoryBox9 = new CategoryBox();
      HeaderPanel.SuspendLayout();
      FooterPanel.SuspendLayout();
      contentFlowLayoutPanel.SuspendLayout();
      SuspendLayout();
      // 
      // Caption
      // 
      Caption.AutoSize = true;
      Caption.CausesValidation = false;
      Caption.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
      HeaderPanel.Size = new Size(545, 62);
      HeaderPanel.TabIndex = 1;
      // 
      // ConfirmButton
      // 
      ConfirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ConfirmButton.BackColor = SystemColors.ActiveCaptionText;
      ConfirmButton.Dock = DockStyle.Top;
      ConfirmButton.FlatAppearance.BorderColor = Color.White;
      ConfirmButton.FlatAppearance.BorderSize = 2;
      ConfirmButton.FlatAppearance.MouseOverBackColor = Color.Silver;
      ConfirmButton.FlatStyle = FlatStyle.Flat;
      ConfirmButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
      ConfirmButton.ForeColor = SystemColors.ControlLightLight;
      ConfirmButton.Location = new Point(0, 0);
      ConfirmButton.Margin = new Padding(3, 6, 3, 6);
      ConfirmButton.Name = "ConfirmButton";
      ConfirmButton.Size = new Size(545, 44);
      ConfirmButton.TabIndex = 8;
      ConfirmButton.Text = "Download and setup";
      ConfirmButton.UseVisualStyleBackColor = false;
      ConfirmButton.Click += ConfirmButton_Click;
      // 
      // FooterPanel
      // 
      FooterPanel.BackColor = SystemColors.ControlText;
      FooterPanel.Controls.Add(ConfirmButton);
      FooterPanel.Dock = DockStyle.Bottom;
      FooterPanel.Location = new Point(0, 677);
      FooterPanel.Name = "FooterPanel";
      FooterPanel.Size = new Size(545, 43);
      FooterPanel.TabIndex = 16;
      // 
      // categoryBox2
      // 
      categoryBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox2.AutoSize = true;
      categoryBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox2.BackColor = Color.Transparent;
      categoryBox2.BorderStyle = BorderStyle.Fixed3D;
      categoryBox2.ForeColor = SystemColors.ControlText;
      categoryBox2.Location = new Point(6, 6);
      categoryBox2.Margin = new Padding(6, 6, 25, 20);
      categoryBox2.Name = "categoryBox2";
      categoryBox2.Size = new Size(505, 56);
      categoryBox2.SQLiteTableBinding = "Utils";
      categoryBox2.TabIndex = 18;
      categoryBox2.Title = "Utils";
      // 
      // categoryBox1
      // 
      categoryBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox1.AutoSize = true;
      categoryBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox1.BackColor = Color.Transparent;
      categoryBox1.BorderStyle = BorderStyle.Fixed3D;
      categoryBox1.ForeColor = SystemColors.ControlText;
      categoryBox1.Location = new Point(6, 334);
      categoryBox1.Margin = new Padding(6, 6, 25, 20);
      categoryBox1.Name = "categoryBox1";
      categoryBox1.Size = new Size(505, 56);
      categoryBox1.SQLiteTableBinding = "GameLaunchers";
      categoryBox1.TabIndex = 17;
      categoryBox1.Title = "Game Launchers";
      // 
      // categoryBox3
      // 
      categoryBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox3.AutoSize = true;
      categoryBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox3.BackColor = Color.Transparent;
      categoryBox3.BorderStyle = BorderStyle.Fixed3D;
      categoryBox3.ForeColor = SystemColors.ControlText;
      categoryBox3.Location = new Point(6, 170);
      categoryBox3.Margin = new Padding(6, 6, 25, 20);
      categoryBox3.Name = "categoryBox3";
      categoryBox3.Size = new Size(505, 56);
      categoryBox3.SQLiteTableBinding = "Coding";
      categoryBox3.TabIndex = 19;
      categoryBox3.Title = "Coding";
      // 
      // categoryBox4
      // 
      categoryBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox4.AutoSize = true;
      categoryBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox4.BackColor = Color.Transparent;
      categoryBox4.BorderStyle = BorderStyle.Fixed3D;
      categoryBox4.ForeColor = SystemColors.ControlText;
      categoryBox4.Location = new Point(6, 252);
      categoryBox4.Margin = new Padding(6, 6, 25, 20);
      categoryBox4.Name = "categoryBox4";
      categoryBox4.Size = new Size(505, 56);
      categoryBox4.SQLiteTableBinding = "Browsers";
      categoryBox4.TabIndex = 20;
      categoryBox4.Title = "Browsers";
      // 
      // categoryBox5
      // 
      categoryBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox5.AutoSize = true;
      categoryBox5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox5.BackColor = Color.Transparent;
      categoryBox5.BorderStyle = BorderStyle.Fixed3D;
      categoryBox5.ForeColor = SystemColors.ControlText;
      categoryBox5.Location = new Point(6, 88);
      categoryBox5.Margin = new Padding(6, 6, 25, 20);
      categoryBox5.Name = "categoryBox5";
      categoryBox5.Size = new Size(505, 56);
      categoryBox5.SQLiteTableBinding = "Gamedev";
      categoryBox5.TabIndex = 21;
      categoryBox5.Title = "Game Development";
      // 
      // contentFlowLayoutPanel
      // 
      contentFlowLayoutPanel.AutoScroll = true;
      contentFlowLayoutPanel.BackColor = SystemColors.ControlText;
      contentFlowLayoutPanel.Controls.Add(categoryBox2);
      contentFlowLayoutPanel.Controls.Add(categoryBox5);
      contentFlowLayoutPanel.Controls.Add(categoryBox3);
      contentFlowLayoutPanel.Controls.Add(categoryBox4);
      contentFlowLayoutPanel.Controls.Add(categoryBox1);
      contentFlowLayoutPanel.Controls.Add(categoryBox6);
      contentFlowLayoutPanel.Controls.Add(categoryBox7);
      contentFlowLayoutPanel.Controls.Add(categoryBox8);
      contentFlowLayoutPanel.Controls.Add(categoryBox9);
      contentFlowLayoutPanel.Dock = DockStyle.Fill;
      contentFlowLayoutPanel.Location = new Point(0, 62);
      contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
      contentFlowLayoutPanel.Size = new Size(545, 658);
      contentFlowLayoutPanel.TabIndex = 22;
      // 
      // categoryBox6
      // 
      categoryBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox6.AutoSize = true;
      categoryBox6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox6.BackColor = Color.Transparent;
      categoryBox6.BorderStyle = BorderStyle.Fixed3D;
      categoryBox6.ForeColor = SystemColors.ControlText;
      categoryBox6.Location = new Point(6, 416);
      categoryBox6.Margin = new Padding(6, 6, 25, 20);
      categoryBox6.Name = "categoryBox6";
      categoryBox6.Size = new Size(505, 56);
      categoryBox6.SQLiteTableBinding = "Benchmarks";
      categoryBox6.TabIndex = 22;
      categoryBox6.Title = "Benchmarks";
      // 
      // categoryBox7
      // 
      categoryBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox7.AutoSize = true;
      categoryBox7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox7.BackColor = Color.Transparent;
      categoryBox7.BorderStyle = BorderStyle.Fixed3D;
      categoryBox7.ForeColor = SystemColors.ControlText;
      categoryBox7.Location = new Point(6, 498);
      categoryBox7.Margin = new Padding(6, 6, 25, 20);
      categoryBox7.Name = "categoryBox7";
      categoryBox7.Size = new Size(505, 56);
      categoryBox7.SQLiteTableBinding = "Drivers";
      categoryBox7.TabIndex = 23;
      categoryBox7.Title = "Drivers";
      // 
      // categoryBox8
      // 
      categoryBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox8.AutoSize = true;
      categoryBox8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox8.BackColor = Color.Transparent;
      categoryBox8.BorderStyle = BorderStyle.Fixed3D;
      categoryBox8.ForeColor = SystemColors.ControlText;
      categoryBox8.Location = new Point(6, 580);
      categoryBox8.Margin = new Padding(6, 6, 25, 20);
      categoryBox8.Name = "categoryBox8";
      categoryBox8.Size = new Size(505, 56);
      categoryBox8.SQLiteTableBinding = "Messengers";
      categoryBox8.TabIndex = 24;
      categoryBox8.Title = "Walkie Talkie";
      // 
      // categoryBox9
      // 
      categoryBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      categoryBox9.AutoSize = true;
      categoryBox9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      categoryBox9.BackColor = Color.Transparent;
      categoryBox9.BorderStyle = BorderStyle.Fixed3D;
      categoryBox9.ForeColor = SystemColors.ControlText;
      categoryBox9.Location = new Point(6, 662);
      categoryBox9.Margin = new Padding(6, 6, 25, 20);
      categoryBox9.Name = "categoryBox9";
      categoryBox9.Size = new Size(505, 56);
      categoryBox9.SQLiteTableBinding = "Misc";
      categoryBox9.TabIndex = 25;
      categoryBox9.Title = "Smth else";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ActiveBorder;
      ClientSize = new Size(545, 720);
      Controls.Add(FooterPanel);
      Controls.Add(contentFlowLayoutPanel);
      Controls.Add(HeaderPanel);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Icon = (Icon)resources.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "MainForm";
      Text = "Easy Setup by ImLewel";
      HeaderPanel.ResumeLayout(false);
      HeaderPanel.PerformLayout();
      FooterPanel.ResumeLayout(false);
      contentFlowLayoutPanel.ResumeLayout(false);
      contentFlowLayoutPanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Label Caption;
    private Panel HeaderPanel;
    private Button ConfirmButton;
    private Panel FooterPanel;
    private CategoryBox categoryBox2;
    private CategoryBox categoryBox1;
    private CategoryBox categoryBox3;
    private CategoryBox categoryBox4;
    private CategoryBox categoryBox5;
    private FlowLayoutPanel contentFlowLayoutPanel;
    private CategoryBox categoryBox6;
    private CategoryBox categoryBox7;
    private CategoryBox categoryBox8;
    private CategoryBox categoryBox9;
  }
}