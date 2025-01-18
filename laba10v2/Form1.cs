using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace laba10v2
{
    public partial class Form1 : Form
    {
        private Color currentColor = Color.Black;
        private string currentShape = "Line";
        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;
        private List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
            comboBoxShapes.Items.Add("Line");
            comboBoxShapes.Items.Add("Rectangle");
            comboBoxShapes.Items.Add("Circle");
            comboBoxShapes.SelectedIndex = 0; // "Line" по умолчанию
            this.DoubleBuffered = true; // Избегаем мерцания
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                }
            }
        }

        private void comboBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShape = comboBoxShapes.SelectedItem.ToString();
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == "Line" || currentShape == "Rectangle" || currentShape == "Circle")
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                shapes.Add(new Shape(currentColor, currentShape, startPoint, endPoint));
                panelDraw.Invalidate();
            }
            isDrawing = false;
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
            if (isDrawing)
            {
                Shape tempShape = new Shape(currentColor, currentShape, startPoint, endPoint);
                tempShape.Draw(e.Graphics); // Рисуем временную фигуру
            }
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location; // Устанавливаем конечную точку в текущую позицию мыши
                panelDraw.Invalidate();
            }
        }
    }

    public class Shape
    {
        private Color color;
        private string shapeType;
        private Point startPoint;
        private Point endPoint;

        public Shape(Color color, string shapeType, Point startPoint, Point endPoint)
        {
            this.color = color;
            this.shapeType = shapeType;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                switch (shapeType)
                {
                    case "Line":
                        g.DrawLine(pen, startPoint, endPoint);
                        break;
                    case "Rectangle":
                        g.DrawRectangle(pen, GetRectangle(startPoint, endPoint));
                        break;
                    case "Circle":
                        DrawCircle(g, pen, startPoint, endPoint);
                        break;
                }
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }

        private void DrawCircle(Graphics g, Pen pen, Point startPoint, Point endPoint)
        {
            // Определяем ширину и высоту для рисования окружности
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);
            g.DrawEllipse(pen, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), width, height);
        }
    }
}