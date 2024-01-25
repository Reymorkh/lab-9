using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Лабораторная_работа__9_формы.Logic;

namespace Лабораторная_работа__9_формы
{
  public class Rectangle
  {
    static int count = 0;

    internal double length, width;

    #region edit
    public void EditLength(double len)
    {
      if (length + len > 0.00009 && length + len < 46340.95)
        length += len;
      else
        MessageBox.Show("Полученное значение не вписывается в рамки 0.00009 < length < 46340.95. Значение сейчас: " + length);
    }

    public void EditWidth(double wid)
    {
      if (width + wid > 0.00009 && width + wid < 46340.95)
        width += wid;
      else
        MessageBox.Show("Полученное значение не вписывается в рамки 0.00009 < length < 46340.95. Значение сейчас: " + width);
    }

    public void Multiply(double multiplier)
    {
      if (this.length * multiplier > 0.00009 && this.length * multiplier < 46340.95 && this.width * multiplier > 0.00009 && this.width * multiplier < 46340.95)
        (length, width) = (length * multiplier, width * multiplier);
      else
        MessageBox.Show("Не удаётся выполнить умножение, в виду превышения ограничения полученным значением.", "Ошибка");
    }

    public static void MultiplyStatic(double multiplier, Rectangle rect)
    {
      if (rect.length * multiplier > 0.00009 && rect.length * multiplier < 46340.95 && rect.width * multiplier > 0.00009 && rect.width * multiplier < 46340.95)
        (rect.length, rect.width) = (rect.length * multiplier, rect.width * multiplier);
      else
        MessageBox.Show("Не удаётся выполнить умножение, в виду превышения ограничения полученным значением.", "Ошибка");
    }
    #endregion

    public static int Count { get { return count; } }

    #region Конструкторы
    public Rectangle()
    {
      length = 0.0001;
      width = 0.0001;
      count++;
    }

    public Rectangle(double len, double wid)
    {
      bool lenCheck = ParamCheck(len), widCheck = ParamCheck(wid);
      if (lenCheck)
        length = len;
      else
        length = 0.0001;
      if (widCheck)
        width = wid;
      else
        width = 0.0001;
      int temp = Convert.ToInt16(lenCheck) + Convert.ToInt16(widCheck);
      if (temp < 2)
        MessageBox.Show("При вводе значений сторон прямоугольника возникл" + (temp == 0 ? "и ошибки. Значения были заменены минимальными." : !lenCheck ? "а ошибка. Значение длины было заменено на минимальное." : "а ошибка. Значение ширины было заменено на минимальное."), "Ошибка"); 
      count++;
    }
    #endregion
  }
}
