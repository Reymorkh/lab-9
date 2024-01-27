namespace Лабораторная_работа__9_формы
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
      VarCounterTextBox = new TextBox();
      VarCounterLabel = new Label();
      SetLengthTextBox = new TextBox();
      SetWidthTextBox = new TextBox();
      CreateObjectButton = new Button();
      CreateDefaultObjectButton = new Button();
      RectangleListBox = new ListBox();
      CopyRectangleButton = new Button();
      InsertRectangleButton = new Button();
      SuspendLayout();
      // 
      // VarCounterTextBox
      // 
      VarCounterTextBox.BackColor = Color.White;
      VarCounterTextBox.Location = new Point(381, 27);
      VarCounterTextBox.Name = "VarCounterTextBox";
      VarCounterTextBox.ReadOnly = true;
      VarCounterTextBox.Size = new Size(147, 23);
      VarCounterTextBox.TabIndex = 1;
      VarCounterTextBox.Text = "0";
      VarCounterTextBox.TextAlign = HorizontalAlignment.Center;
      // 
      // VarCounterLabel
      // 
      VarCounterLabel.AutoSize = true;
      VarCounterLabel.Location = new Point(381, 9);
      VarCounterLabel.Name = "VarCounterLabel";
      VarCounterLabel.Size = new Size(147, 15);
      VarCounterLabel.TabIndex = 2;
      VarCounterLabel.Text = "Счётчик объектов класса";
      // 
      // SetLengthTextBox
      // 
      SetLengthTextBox.Location = new Point(381, 56);
      SetLengthTextBox.Name = "SetLengthTextBox";
      SetLengthTextBox.Size = new Size(70, 23);
      SetLengthTextBox.TabIndex = 3;
      // 
      // SetWidthTextBox
      // 
      SetWidthTextBox.Location = new Point(457, 56);
      SetWidthTextBox.Name = "SetWidthTextBox";
      SetWidthTextBox.Size = new Size(70, 23);
      SetWidthTextBox.TabIndex = 4;
      // 
      // CreateObjectButton
      // 
      CreateObjectButton.Location = new Point(419, 85);
      CreateObjectButton.Name = "CreateObjectButton";
      CreateObjectButton.Size = new Size(75, 23);
      CreateObjectButton.TabIndex = 5;
      CreateObjectButton.Text = "Создать";
      CreateObjectButton.UseVisualStyleBackColor = true;
      CreateObjectButton.Click += CreateObjectButton_Click;
      // 
      // CreateDefaultObjectButton
      // 
      CreateDefaultObjectButton.Location = new Point(381, 114);
      CreateDefaultObjectButton.Name = "CreateDefaultObjectButton";
      CreateDefaultObjectButton.Size = new Size(147, 23);
      CreateDefaultObjectButton.TabIndex = 6;
      CreateDefaultObjectButton.Text = "Создать по умолчанию";
      CreateDefaultObjectButton.UseVisualStyleBackColor = true;
      CreateDefaultObjectButton.Click += CreateDefaultObjectButton_Click;
      // 
      // RectangleListBox
      // 
      RectangleListBox.FormattingEnabled = true;
      RectangleListBox.ItemHeight = 15;
      RectangleListBox.Location = new Point(15, 27);
      RectangleListBox.Name = "RectangleListBox";
      RectangleListBox.Size = new Size(360, 139);
      RectangleListBox.TabIndex = 7;
      RectangleListBox.MouseDoubleClick += RectangleListBox_MouseDoubleClick;
      // 
      // CopyRectangleButton
      // 
      CopyRectangleButton.Location = new Point(381, 143);
      CopyRectangleButton.Name = "CopyRectangleButton";
      CopyRectangleButton.Size = new Size(70, 23);
      CopyRectangleButton.TabIndex = 8;
      CopyRectangleButton.Text = "Copy";
      CopyRectangleButton.UseVisualStyleBackColor = true;
      CopyRectangleButton.Click += CopyRectangleButton_Click;
      // 
      // InsertRectangleButton
      // 
      InsertRectangleButton.Location = new Point(458, 143);
      InsertRectangleButton.Name = "InsertRectangleButton";
      InsertRectangleButton.Size = new Size(70, 23);
      InsertRectangleButton.TabIndex = 9;
      InsertRectangleButton.Text = "Insert";
      InsertRectangleButton.UseVisualStyleBackColor = true;
      InsertRectangleButton.Click += InsertRectangleButton_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(540, 172);
      Controls.Add(InsertRectangleButton);
      Controls.Add(CopyRectangleButton);
      Controls.Add(RectangleListBox);
      Controls.Add(CreateDefaultObjectButton);
      Controls.Add(CreateObjectButton);
      Controls.Add(SetWidthTextBox);
      Controls.Add(SetLengthTextBox);
      Controls.Add(VarCounterLabel);
      Controls.Add(VarCounterTextBox);
      MaximumSize = new Size(556, 211);
      MinimumSize = new Size(556, 211);
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Основное поле";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private TextBox VarCounterTextBox;
    private Label VarCounterLabel;
    private TextBox SetLengthTextBox;
    private TextBox SetWidthTextBox;
    private Button CreateObjectButton;
    private Button CreateDefaultObjectButton;
    private ListBox RectangleListBox;
    private Button CopyRectangleButton;
    private Button InsertRectangleButton;
  }
}