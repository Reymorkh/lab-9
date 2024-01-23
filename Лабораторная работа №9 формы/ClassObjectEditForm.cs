using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Лабораторная_работа__9_формы.Logic;

namespace Лабораторная_работа__9_формы
{
  public partial class ClassObjectEditForm : Form
  {
    int index;

    public ClassObjectEditForm(int number)
    {
      InitializeComponent();
      index = number;
      LengthLabel.Text += Rectangles[index].length;
      WidthLabel.Text += Rectangles[index].width;
    }

    private void EditLengthButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(LengthTextBox.Text, out double temp))
      {
        Rectangles[index].EditLength(temp);
        LengthLabel.Text = "Длина: " + Rectangles[index].length;
      }
    }

    private void EditWidthButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(WidthTextBox.Text, out double temp))
      {
        Rectangles[index].EditWidth(temp);
        WidthLabel.Text = "Ширина: " + Rectangles[index].width;
      }
    }
  }
}
