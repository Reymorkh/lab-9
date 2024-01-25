using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__9_формы
{
  public static class Logic
  {
    public static List<Rectangle> Rectangles = new List<Rectangle>();

    public static Rectangle CreateRectangle(double length, double width)
    {
      Rectangle rect = new Rectangle(length, width);
      Rectangles.Add(rect);
      return rect;
    }

    public static Rectangle CreateRectangle()
    {
      Rectangle rect = new Rectangle();
      Rectangles.Add(rect);
      return rect;
    }

    public static bool ParamCheck(double par)
    {
      if (par > 0.00009 && par < 46340.95)
        return true;
      return false;
    }
  }
}
