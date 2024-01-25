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

    public void ValueUpdate() => VarCounterTextBox.Text = Convert.ToString(Rectangle.Count);

    #region Create Rectangle Buttons
    private void CreateObjectButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(SetLengthTextBox.Text, out double length) && double.TryParse(SetWidthTextBox.Text, out double width))
      {
        Rectangle rect = CreateRectangle(length, width);
        ValueUpdate();
        RectangleListBox.Items.Add("Прямоугольник #" + Rectangles.Count + " Длина: " + rect.length + " Ширина: " + rect.width);
      }
    }

    private void CreateDefaultObjectButton_Click(object sender, EventArgs e)
    {
      Rectangle rect = CreateRectangle();
      ValueUpdate();
      RectangleListBox.Items.Add("Прямоугольник #" + Rectangles.Count + " Длина: " + rect.length + " Ширина: " + rect.width);
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
        RectangleListBox.Items.RemoveAt(index);
        RectangleListBox.Items.Insert(index, "Прямоугольник #" + (index + 1) + " Длина: " + Rectangles[index].length + " Ширина: " + Rectangles[index].width);
      }
    }
  }
}