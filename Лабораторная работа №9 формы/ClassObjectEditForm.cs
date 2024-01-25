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

    public static void DoubleParseFailMessage() => MessageBox.Show("Не удалось преобразовать ввод в тип double.", "Ошибка");

    public ClassObjectEditForm(int number)
    {
      InitializeComponent();
      index = number;
      LengthLabel.Text += Rectangles[index].length;
      WidthLabel.Text += Rectangles[index].width;
    }

    public void LabelsUpdate()
    {
      LengthLabel.Text = "Длина: " + Rectangles[index].length;
      WidthLabel.Text = "Ширина: " + Rectangles[index].width;
    }

    private void EditLengthButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(LengthTextBox.Text, out double temp))
      {
        Rectangles[index].EditLength(temp);
        LabelsUpdate();
      }
      else
        DoubleParseFailMessage();
    }

    private void EditWidthButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(WidthTextBox.Text, out double temp))
      {
        Rectangles[index].EditWidth(temp);
        LabelsUpdate();
      }
      else
        DoubleParseFailMessage();
    }

    private void MultiplicationButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(MultiplicationTextBox.Text, out double temp))
      {
        Rectangles[index].Multiply(temp);
        LabelsUpdate();
      }
      else
        DoubleParseFailMessage();
      //if (double.TryParse(MultiplicationTextBox.Text, out double temp))
      //{
      //  Rectangle.MultiplyStatic(temp, Rectangles[index]);
      //  LabelsUpdate();
      //}
      //else
      //  DoubleParseFail();
    }
  }
}
