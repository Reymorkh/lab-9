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

    public void ValueUpdate(int count) => VarCounterTextBox.Text = Convert.ToString(count);

    #region Counter update
    public void ClassVarInit(double length, double width) => ValueUpdate(ClassInit(length, width).Count);

    public void ClassVarInit() => ValueUpdate(ClassInit().Count);
    #endregion

    #region Create Rectangle Buttons
    private void CreateObjectButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(SetLengthTextBox.Text, out double length) && double.TryParse(SetWidthTextBox.Text, out double width))
      {
        ClassVarInit(length, width);
        int listLength = Rectangles.Count - 1;
        RectangleListBox.Items.Add("Прямоугольник #" + (listLength + 1) + " Длина: " + Rectangles[listLength].length + " Ширина: " + Rectangles[listLength].width);
      }
    }

    private void CreateDefaultObjectButton_Click(object sender, EventArgs e)
    {
      ClassVarInit();
      int listLength = Rectangles.Count - 1;
      RectangleListBox.Items.Add("Прямоугольник #" + (listLength + 1) + " Длина: " + Rectangles[listLength].length + " Ширина: " + Rectangles[listLength].width);
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