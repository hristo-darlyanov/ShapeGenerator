using System.Drawing.Text;

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
            g.DrawRectangle(p, panelX, panelY, size, size);
        }

        private Color RandomColor()
        {
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }
    }
}