namespace Лабораторная_работа__9_формы
{
  partial class ClassObjectEditForm
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
      LengthTextBox = new TextBox();
      WidthTextBox = new TextBox();
      LengthLabel = new Label();
      WidthLabel = new Label();
      EditLengthButton = new Button();
      EditWidthButton = new Button();
      SuspendLayout();
      // 
      // LengthTextBox
      // 
      LengthTextBox.Location = new Point(12, 58);
      LengthTextBox.Name = "LengthTextBox";
      LengthTextBox.Size = new Size(164, 23);
      LengthTextBox.TabIndex = 0;
      // 
      // WidthTextBox
      // 
      WidthTextBox.Location = new Point(182, 58);
      WidthTextBox.Name = "WidthTextBox";
      WidthTextBox.Size = new Size(164, 23);
      WidthTextBox.TabIndex = 2;
      // 
      // LengthLabel
      // 
      LengthLabel.AutoSize = true;
      LengthLabel.Location = new Point(12, 40);
      LengthLabel.Name = "LengthLabel";
      LengthLabel.Size = new Size(48, 15);
      LengthLabel.TabIndex = 3;
      LengthLabel.Text = "Длина: ";
      // 
      // WidthLabel
      // 
      WidthLabel.AutoSize = true;
      WidthLabel.Location = new Point(182, 40);
      WidthLabel.Name = "WidthLabel";
      WidthLabel.Size = new Size(58, 15);
      WidthLabel.TabIndex = 4;
      WidthLabel.Text = "Ширина: ";
      // 
      // EditLengthButton
      // 
      EditLengthButton.Location = new Point(59, 87);
      EditLengthButton.Name = "EditLengthButton";
      EditLengthButton.Size = new Size(75, 23);
      EditLengthButton.TabIndex = 5;
      EditLengthButton.Text = "Edit";
      EditLengthButton.UseVisualStyleBackColor = true;
      EditLengthButton.Click += EditLengthButton_Click;
      // 
      // EditWidthButton
      // 
      EditWidthButton.Location = new Point(224, 87);
      EditWidthButton.Name = "EditWidthButton";
      EditWidthButton.Size = new Size(75, 23);
      EditWidthButton.TabIndex = 6;
      EditWidthButton.Text = "Edit";
      EditWidthButton.UseVisualStyleBackColor = true;
      EditWidthButton.Click += EditWidthButton_Click;
      // 
      // ClassObjectEditForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(360, 134);
      Controls.Add(EditWidthButton);
      Controls.Add(EditLengthButton);
      Controls.Add(WidthLabel);
      Controls.Add(LengthLabel);
      Controls.Add(WidthTextBox);
      Controls.Add(LengthTextBox);
      Name = "ClassObjectEditForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Окно редактирования";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox LengthTextBox;
    private TextBox WidthTextBox;
    private Label LengthLabel;
    private Label WidthLabel;
    private Button EditLengthButton;
    private Button EditWidthButton;
  }
}