namespace EasySetup
{
  partial class CategoryBox
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
      labelName = new Label();
      addBtn = new Button();
      removeBtn = new Button();
      editBtn = new Button();
      deleteButton = new Button();
      tableContainer = new DataGridView();
      selectionColumn = new DataGridViewCheckBoxColumn();
      nameColumn = new DataGridViewTextBoxColumn();
      normalMode = new DataGridViewCheckBoxColumn();
      quietMode = new DataGridViewCheckBoxColumn();
      minimizeMode = new DataGridViewCheckBoxColumn();
      ((System.ComponentModel.ISupportInitialize)tableContainer).BeginInit();
      SuspendLayout();
      // 
      // labelName
      // 
      labelName.AutoSize = true;
      labelName.Font = new Font("Consolas", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
      labelName.ForeColor = SystemColors.ControlLightLight;
      labelName.Location = new Point(3, 3);
      labelName.Margin = new Padding(3, 3, 3, 0);
      labelName.MaximumSize = new Size(188, 0);
      labelName.Name = "labelName";
      labelName.Size = new Size(40, 18);
      labelName.TabIndex = 9;
      labelName.Text = "Text";
      // 
      // addBtn
      // 
      addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      addBtn.FlatAppearance.BorderSize = 0;
      addBtn.FlatStyle = FlatStyle.Flat;
      addBtn.Font = new Font("Consolas", 6F, FontStyle.Regular, GraphicsUnit.Point);
      addBtn.ForeColor = Color.Lime;
      addBtn.Location = new Point(184, 3);
      addBtn.Name = "addBtn";
      addBtn.Size = new Size(18, 18);
      addBtn.TabIndex = 11;
      addBtn.Text = "➕";
      addBtn.TextAlign = ContentAlignment.MiddleLeft;
      addBtn.TextImageRelation = TextImageRelation.TextAboveImage;
      addBtn.UseVisualStyleBackColor = true;
      addBtn.Click += addBtn_Click;
      // 
      // removeBtn
      // 
      removeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      removeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      removeBtn.FlatAppearance.BorderSize = 0;
      removeBtn.FlatStyle = FlatStyle.Flat;
      removeBtn.Font = new Font("Consolas", 6F, FontStyle.Regular, GraphicsUnit.Point);
      removeBtn.ForeColor = Color.Crimson;
      removeBtn.Location = new Point(208, 3);
      removeBtn.Name = "removeBtn";
      removeBtn.Size = new Size(18, 18);
      removeBtn.TabIndex = 12;
      removeBtn.Text = "➖";
      removeBtn.TextAlign = ContentAlignment.MiddleLeft;
      removeBtn.TextImageRelation = TextImageRelation.TextAboveImage;
      removeBtn.UseVisualStyleBackColor = true;
      removeBtn.Click += removeBtn_Click;
      // 
      // editBtn
      // 
      editBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      editBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      editBtn.FlatAppearance.BorderSize = 0;
      editBtn.FlatStyle = FlatStyle.Flat;
      editBtn.Font = new Font("Consolas", 6F, FontStyle.Regular, GraphicsUnit.Point);
      editBtn.ForeColor = Color.Gold;
      editBtn.Location = new Point(232, 3);
      editBtn.Name = "editBtn";
      editBtn.Size = new Size(18, 18);
      editBtn.TabIndex = 13;
      editBtn.Text = "✏";
      editBtn.TextAlign = ContentAlignment.MiddleLeft;
      editBtn.TextImageRelation = TextImageRelation.TextAboveImage;
      editBtn.UseVisualStyleBackColor = true;
      editBtn.Click += editBtn_Click;
      // 
      // deleteButton
      // 
      deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      deleteButton.FlatAppearance.BorderSize = 0;
      deleteButton.FlatStyle = FlatStyle.Flat;
      deleteButton.Font = new Font("Consolas", 6F, FontStyle.Regular, GraphicsUnit.Point);
      deleteButton.ForeColor = Color.PaleTurquoise;
      deleteButton.Location = new Point(256, 3);
      deleteButton.Name = "deleteButton";
      deleteButton.Size = new Size(18, 18);
      deleteButton.TabIndex = 14;
      deleteButton.Text = "D";
      deleteButton.TextAlign = ContentAlignment.MiddleLeft;
      deleteButton.TextImageRelation = TextImageRelation.TextAboveImage;
      deleteButton.UseVisualStyleBackColor = true;
      deleteButton.Click += deleteButton_Click;
      // 
      // tableContainer
      // 
      tableContainer.AllowUserToAddRows = false;
      tableContainer.AllowUserToDeleteRows = false;
      tableContainer.AllowUserToResizeColumns = false;
      tableContainer.AllowUserToResizeRows = false;
      tableContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tableContainer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      tableContainer.BackgroundColor = SystemColors.ControlText;
      tableContainer.BorderStyle = BorderStyle.None;
      tableContainer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = SystemColors.ControlText;
      dataGridViewCellStyle1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
      dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLight;
      dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      tableContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      tableContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      tableContainer.Columns.AddRange(new DataGridViewColumn[] { selectionColumn, nameColumn, normalMode, quietMode, minimizeMode });
      dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = SystemColors.ControlText;
      dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      tableContainer.DefaultCellStyle = dataGridViewCellStyle2;
      tableContainer.EnableHeadersVisualStyles = false;
      tableContainer.GridColor = SystemColors.ControlLightLight;
      tableContainer.Location = new Point(0, 27);
      tableContainer.MultiSelect = false;
      tableContainer.Name = "tableContainer";
      dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = SystemColors.Control;
      dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      tableContainer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      tableContainer.RowHeadersVisible = false;
      tableContainer.RowHeadersWidth = 51;
      dataGridViewCellStyle4.BackColor = SystemColors.ControlText;
      dataGridViewCellStyle4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = SystemColors.ControlLightLight;
      tableContainer.RowsDefaultCellStyle = dataGridViewCellStyle4;
      tableContainer.ScrollBars = ScrollBars.None;
      tableContainer.Size = new Size(272, 22);
      tableContainer.TabIndex = 15;
      tableContainer.CellContentClick += tableContainer_CellContentClick;
      // 
      // selectionColumn
      // 
      selectionColumn.Frozen = true;
      selectionColumn.HeaderText = "✔";
      selectionColumn.MinimumWidth = 26;
      selectionColumn.Name = "selectionColumn";
      selectionColumn.Resizable = DataGridViewTriState.False;
      selectionColumn.ToolTipText = "Tick this if you want this to be installed";
      selectionColumn.Width = 28;
      // 
      // nameColumn
      // 
      nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      nameColumn.HeaderText = "Name";
      nameColumn.MinimumWidth = 6;
      nameColumn.Name = "nameColumn";
      nameColumn.ReadOnly = true;
      nameColumn.ToolTipText = "Name of the program to install";
      // 
      // normalMode
      // 
      normalMode.HeaderText = "N";
      normalMode.MinimumWidth = 26;
      normalMode.Name = "normalMode";
      normalMode.Resizable = DataGridViewTriState.False;
      normalMode.ToolTipText = "Whether install in normal mode (installation window will be shown to user)";
      normalMode.Width = 26;
      // 
      // quietMode
      // 
      quietMode.HeaderText = "Q";
      quietMode.MinimumWidth = 26;
      quietMode.Name = "quietMode";
      quietMode.ToolTipText = "Whether install in quiet mode (installation window will not be shown to user)";
      quietMode.Width = 26;
      // 
      // minimizeMode
      // 
      minimizeMode.HeaderText = "M";
      minimizeMode.MinimumWidth = 26;
      minimizeMode.Name = "minimizeMode";
      minimizeMode.ToolTipText = "Whether install in minimized mode (installation window will be shown as small progress window to user)";
      minimizeMode.Width = 26;
      // 
      // CategoryBox
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      AutoSizeMode = AutoSizeMode.GrowAndShrink;
      BackColor = Color.Transparent;
      Controls.Add(tableContainer);
      Controls.Add(deleteButton);
      Controls.Add(editBtn);
      Controls.Add(removeBtn);
      Controls.Add(addBtn);
      Controls.Add(labelName);
      ForeColor = SystemColors.ControlText;
      Name = "CategoryBox";
      Size = new Size(277, 52);
      ((System.ComponentModel.ISupportInitialize)tableContainer).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label labelName;
    private Button addBtn;
    private Button removeBtn;
    private Button editBtn;
    private Button deleteButton;
    internal DataGridView tableContainer;
    private DataGridViewCheckBoxColumn selectionColumn;
    private DataGridViewTextBoxColumn nameColumn;
    private DataGridViewCheckBoxColumn normalMode;
    private DataGridViewCheckBoxColumn quietMode;
    private DataGridViewCheckBoxColumn minimizeMode;
  }
}
