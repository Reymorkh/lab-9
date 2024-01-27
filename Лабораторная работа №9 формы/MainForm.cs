using System;
using static Лабораторная_работа__9_формы.Logic;

namespace Лабораторная_работа__9_формы
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      //VarCounterTextBox.DataBindings.Add(new Binding("Text", new Rectangle(), "count"));
    }

    public void AddValueToListBox(int index) => RectangleListBox.Items.Add("Прямоугольник #" + index + " Длина: " + Rectangles[index - 1].GetLength + " Ширина: " + Rectangles[index - 1].GetWidth);
    
    public void ListBoxDataReplacement(int index)
    {
      RectangleListBox.Items.RemoveAt(index);
      RectangleListBox.Items.Insert(index, "Прямоугольник #" + (index + 1) + " Длина: " + Rectangles[index].GetLength + " Ширина: " + Rectangles[index].GetWidth);
    }

    public void ValueUpdate() => VarCounterTextBox.Text = Convert.ToString(Rectangle.Count);

    #region Create Rectangle Buttons
    private void CreateObjectButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(SetLengthTextBox.Text, out double length) && double.TryParse(SetWidthTextBox.Text, out double width))
      {
        CreateRectangle(length, width);
        ValueUpdate();
        AddValueToListBox(Rectangles.Count);
      }
    }

    private void CreateDefaultObjectButton_Click(object sender, EventArgs e)
    {
      CreateRectangle();
      ValueUpdate();
      AddValueToListBox(Rectangles.Count);
    }
    #endregion

    private void RectangleListBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      int index = RectangleListBox.SelectedIndex;
      if (index != -1)
      {
        ClassObjectEditForm f = new ClassObjectEditForm(index);
        f.ShowDialog();
        f.Dispose();
        ListBoxDataReplacement(index);
      }
    }

    private void CopyRectangleButton_Click(object sender, EventArgs e)
    {
      int temp = RectangleListBox.SelectedIndex;
      if (temp != -1)
        CopyIndex = temp;
    }

    private void InsertRectangleButton_Click(object sender, EventArgs e)
    {
      int temp = RectangleListBox.SelectedIndex;
      if (CopyIndex != -1 && temp != CopyIndex)
      {
        Rectangles[temp] = new Rectangle(Rectangles[CopyIndex]);
        ListBoxDataReplacement(temp);
        CopyIndex = -1;
      }

    }
  }
}