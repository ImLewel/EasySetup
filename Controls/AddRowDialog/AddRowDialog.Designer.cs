namespace EasySetup
{
  partial class AddRowDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRowDialog));
      label1 = new Label();
      label2 = new Label();
      NameTextBox = new TextBox();
      LinkTextBox = new TextBox();
      submitBtn = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = Color.Transparent;
      label1.Font = new Font("Consolas", 9F, FontStyle.Underline, GraphicsUnit.Point);
      label1.ForeColor = SystemColors.ControlLightLight;
      label1.Location = new Point(12, 9);
      label1.Name = "label1";
      label1.Size = new Size(264, 18);
      label1.TabIndex = 0;
      label1.Text = "Specify the name of the program:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.BackColor = Color.Transparent;
      label2.Font = new Font("Consolas", 9F, FontStyle.Underline, GraphicsUnit.Point);
      label2.ForeColor = SystemColors.ControlLightLight;
      label2.Location = new Point(12, 62);
      label2.Name = "label2";
      label2.Size = new Size(264, 18);
      label2.TabIndex = 1;
      label2.Text = "Specify the link of the program:";
      // 
      // NameTextBox
      // 
      NameTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      NameTextBox.Location = new Point(12, 32);
      NameTextBox.Name = "NameTextBox";
      NameTextBox.Size = new Size(312, 25);
      NameTextBox.TabIndex = 2;
      // 
      // LinkTextBox
      // 
      LinkTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      LinkTextBox.Location = new Point(12, 84);
      LinkTextBox.Name = "LinkTextBox";
      LinkTextBox.Size = new Size(312, 25);
      LinkTextBox.TabIndex = 3;
      // 
      // submitBtn
      // 
      submitBtn.FlatAppearance.BorderColor = Color.White;
      submitBtn.FlatAppearance.BorderSize = 3;
      submitBtn.FlatStyle = FlatStyle.Flat;
      submitBtn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      submitBtn.ForeColor = SystemColors.ControlLightLight;
      submitBtn.Location = new Point(12, 115);
      submitBtn.Name = "submitBtn";
      submitBtn.Size = new Size(94, 29);
      submitBtn.TabIndex = 4;
      submitBtn.Text = "Submit";
      submitBtn.UseVisualStyleBackColor = true;
      submitBtn.Click += submitBtn_Click;
      // 
      // AddRowDialog
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlText;
      ClientSize = new Size(336, 158);
      Controls.Add(submitBtn);
      Controls.Add(LinkTextBox);
      Controls.Add(NameTextBox);
      Controls.Add(label2);
      Controls.Add(label1);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "AddRowDialog";
      ShowIcon = false;
      Text = "Adding new row...";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    protected TextBox NameTextBox;
    protected TextBox LinkTextBox;
    private Button submitBtn;
  }
}