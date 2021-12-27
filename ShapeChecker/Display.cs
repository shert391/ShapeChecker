using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShapeChecker
{
    public partial class Display : Form
    {
        private List<Segment> Shape = new List<Segment>();
        private Point Z;

        public Display()
        {
            InitializeComponent();
        }

        private void DrawLine(Point one, Point two)
        {
            Graphips.Series["Lines"].Points.AddXY(one.X, one.Y);
            Graphips.Series["Lines"].Points.AddXY(two.X, two.Y);
        }

        private void DrawPoint(Point point, bool istargetpoint = false)
        {
            int indexPoint;
            if (!istargetpoint)
            {
                indexPoint = Graphips.Series["Points"].Points.AddXY(point.X, point.Y);
                Graphips.Series["Points"].Points[indexPoint].Label = "(" + point.X + " " + point.Y + ")";
            }
            else
            {
                indexPoint = Graphips.Series["TargetPoint"].Points.AddXY(point.X, point.Y);
                Graphips.Series["TargetPoint"].Points[indexPoint].Label = "Z = " + "(" + point.X + " " + point.Y + ")";
            }
        }

        private void DrawGraphics()
        {
            for (int i = 0; i < Shape.Count - 1; i++)
            {
                if (i == 0)
                {
                    DrawPoint(Shape[i].PointOne);
                    DrawPoint(Shape[i].PointTwo);
                    DrawLine(Shape[i].PointOne, Shape[i].PointTwo);
                }
                else
                {
                    DrawPoint(Shape[i].PointTwo);
                    DrawLine(Shape[i].PointOne, Shape[i].PointTwo);
                }
                if (i == Shape.Count - 2)
                {
                    DrawLine(Shape[i + 1].PointOne, Shape[i + 1].PointTwo);
                }
            }
            DrawPoint(Z, istargetpoint: true);
        }
        private void ReadFromFile(ref List<Segment> pointers)
        {
            double[] cordZ;
            string data = "";
            using (StreamReader sr = new StreamReader("input.txt", Encoding.Default))
            {
                cordZ = sr.ReadLine().TrimEnd().Split().Select(double.Parse).ToArray();
                data = sr.ReadLine().TrimEnd();
            }
            Z = new Point(cordZ[0], cordZ[1]);
            double[] buffer = data.Split().Select(double.Parse).ToArray();
            double x_1 = 0; double y_1 = 0; double x_2 = 0; double y_2 = 0;
            int iter = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                iter++;
                if (i < 4)
                {
                    switch (iter)
                    {
                        case 1:
                            x_1 = buffer[i];
                            break;
                        case 2:
                            y_1 = buffer[i];
                            break;
                        case 3:
                            x_2 = buffer[i];
                            break;
                        case 4:
                            y_2 = buffer[i];
                            pointers.Add(new Segment(new Point(x_1, y_1), new Point(x_2, y_2)));
                            x_1 = x_2;
                            y_1 = y_2;
                            iter = 0;
                            break;
                    }
                }
                else
                {
                    switch (iter)
                    {
                        case 1:
                            x_2 = buffer[i];
                            break;
                        case 2:
                            y_2 = buffer[i];
                            pointers.Add(new Segment(new Point(x_1, y_1), new Point(x_2, y_2)));
                            x_1 = x_2;
                            y_1 = y_2;
                            iter = 0;
                            break;
                    }
                }
            }
            pointers.Add(new Segment(pointers[0].PointOne, pointers[pointers.Count - 1].PointTwo));
        } // читаем из "input.txt", первая строка - кординаты Z, вторая - координаты точек фигуры. Формат: (x y x y x y...n*2)
        private void Display_Load(object sender, EventArgs e)
        {
            ReadFromFile(ref Shape);
            if (ShapeManager.LiesOnTheSide(Shape, Z))
            {
                StatusProgramm.Text = "Результат: точка лежит на стороне многоугольника!";
            }
            else if (ShapeManager.LiesInside(Shape, Z))
            {
                StatusProgramm.Text = "Результат: точка лежит внутри многоугольника!";
            }
            else
            {
                StatusProgramm.Text = "Результат: точка лежит за пределами многоугольника!";
            }
            DrawGraphics();
        }

        private void Graphips_Enter(object sender, EventArgs e)
        {
            StatusProgramm.Focus();
        }
    }
}
