using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Security.Policy;
using System.Threading;

namespace ShapeGenerator
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new Random();
        private bool isSquareGenerated;
        private bool isTriangleGenerated;
        private bool isCircleGenerated;
        Thread squareThread;
        Thread triangleThread;
        Thread circleThread;
        Graphics g;
        int panelY;
        int panelX;
        int panelYDiff;
        int panelXDiff;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetValues()
        {
            g = CreateGraphics();
            panelY = random.Next(0, Height);
            panelX = random.Next(0, Width);
            panelYDiff = Height - panelY;
            panelXDiff = Width - panelX;
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            squareThread = new Thread(SquareThread);
            isSquareGenerated = true;
            squareThread.Start();
        }

        private void SquareThread()
        {
            while (isSquareGenerated)
            {
                GenerateSquare();
                Thread.Sleep(100);
            }
        }

        private void triangleBtn_Click_1(object sender, EventArgs e)
        {
            triangleThread = new Thread(TriangleThread);
            isTriangleGenerated = true;
            triangleThread.Start();
        }

        private void TriangleThread()
        {
            while (isTriangleGenerated)
            {
                GenerateTriangle();
                Thread.Sleep(100);
            }
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            circleThread = new Thread(CircleThread);
            isCircleGenerated = true;
            circleThread.Start();
        }

        private void CircleThread()
        {
            while (isCircleGenerated)
            {
                GenerateCircle();
                Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isSquareGenerated = false;
            isTriangleGenerated = false;
            isCircleGenerated = false;
        }

        private Brush PickBrush()
        {
            Brush result = Brushes.Transparent;
            Type brushesType = typeof(Brushes);
            PropertyInfo[] properties = brushesType.GetProperties();
            int randomBrush = random.Next(properties.Length);
            result = (Brush)properties[randomBrush].GetValue(null, null);
            return result;
        }

        private void GenerateSquare()
        {
            int size;
            GetValues();
            if (panelYDiff < panelXDiff)
            {
                size = panelYDiff / 4;
            }
            else
            {
                size = panelXDiff / 4;
            }
            g.FillRectangle(PickBrush(), panelX, panelY, size, size);
        }

        private void GenerateTriangle()
        {
            int size;
            GetValues();
            if (panelYDiff < panelXDiff)
            {
                size = panelYDiff / 6;
            }
            else
            {
                size = panelXDiff / 6;
            }
            FillTriangle(new Point(panelX, panelY), size);
        }

        private void GenerateCircle()
        {
            int size;
            GetValues();
            if (panelYDiff < panelXDiff)
            {
                size = panelYDiff / 4;
            }
            else
            {
                size = panelXDiff / 4;
            }
            g.FillEllipse(PickBrush(), panelX, panelY, size, size);
        }

        private void FillTriangle(Point p, int size)
        {
            Graphics g = CreateGraphics();
            g.FillPolygon(PickBrush(), new Point[] { p, new Point(p.X - size, p.Y + (int)(size * Math.Sqrt(3))), new Point(p.X + size, p.Y + (int)(size * Math.Sqrt(3))) });
        }
    }
}