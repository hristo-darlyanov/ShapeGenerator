using System.Drawing.Text;
using System.Reflection;

namespace ShapeGenerator
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            int size;
            Graphics g = CreateGraphics();
            Pen p = new Pen(RandomColor(), 3);
            int panelY = random.Next(0, Height);
            int panelX = random.Next(0, Width);
            int panelYDiff = Height - panelY;
            int panelXDiff = Width - panelX;
            if (panelYDiff < panelXDiff)
            {
                size = panelYDiff / 2;
            }
            else
            {
                size = panelXDiff / 2;
            }
            g.FillRectangle(PickBrush(), panelX, panelY, size, size);
        }

        private Color RandomColor()
        {
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {

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
    }
}