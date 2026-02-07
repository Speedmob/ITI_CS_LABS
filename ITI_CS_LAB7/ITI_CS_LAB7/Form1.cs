namespace ITI_CS_LAB7
{
    public partial class Form1 : Form
    {
        string[] years = { "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997" };
        int[] revenue = { 150, 170, 180, 175, 200, 250, 210, 240, 280, 140 };

        PointF[] linePoints;

        private Color currentThemeColor = Color.Blue;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.Text = "Abdelrahim Chart";

            this.KeyPreview = true;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Control)
            {
                if (e.KeyCode == Keys.R) currentThemeColor = Color.Red;
                else if (e.KeyCode == Keys.B) currentThemeColor = Color.Blue;
                else if (e.KeyCode == Keys.G) currentThemeColor = Color.Green;

                this.Invalidate();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            for (int i = 0; i < years.Length; i++)
            {
                if (Math.Abs(e.X - linePoints[i].X) < 15 && Math.Abs(e.Y - linePoints[i].Y) < 15)
                {
                    string msg = $"Year: {years[i]}\nRevenue: {revenue[i]}\n\nExact PointF: {linePoints[i]}";
                    MessageBox.Show(msg, "Point Data");
                    return;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            linePoints = new PointF[years.Length];

            int marginLeft = 50;
            int marginBottom = 50;
            int marginTop = 100;
            int chartWidth = 400;
            int chartHeight = 300;

            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Brush blueBrush = Brushes.RoyalBlue;

            g.DrawString("Abdelrahim Chart", titleFont, blueBrush, 250, 20);

            float maxVal = 300f;
            
            using (Brush greyBrush = new SolidBrush(currentThemeColor))
            {
                DrawChart(greyBrush, g, marginLeft, marginTop, marginBottom, 0.7f, chartWidth, chartHeight, maxVal, linePoints);
            }

            Pen bluePen = new Pen(Color.Blue, 2);
            g.DrawLines(bluePen, linePoints);

            int listX = 1100;
            int listY = 100;
            int lineHeight = 25;
            int horizSpacing = 80;
            int vertSpacing = 30;

            Font dataHeaderFont = new Font("Arial", 10, FontStyle.Regular);
            Font dataFont = new Font("Arial", 10);

            Brush textBrush = Brushes.Blue;
            
            drawTable(textBrush, "Year", "Revenue", dataHeaderFont, dataFont, listX, listY, lineHeight, horizSpacing, vertSpacing, g);
        }

        public void DrawBar(Brush barBrush, float barX, float barY, float barWidth, float barHeight, Graphics g)
        {
            g.FillRectangle(barBrush, barX, barY, barWidth, barHeight);
        }
        public void DrawChart(Brush barBrush, Graphics g, int marginLeft, int marginTop, int marginBottom, float barWidthPer, 
            int chartWidth, int chartHeight, float maxVal, PointF[] linePoints)
        {
            float pixelsPerUnit = chartHeight / maxVal;
            float slotWidth = chartWidth / (float)years.Length;
            float barWidth = slotWidth * barWidthPer;

            for (int i = 0; i < years.Length; i++)
            {
                float barHeight = revenue[i] * pixelsPerUnit;

                float x = marginLeft + (i * slotWidth);
                float y = (marginTop + chartHeight) - barHeight;

                float barX = x + (slotWidth - barWidth) / 2;

                DrawBar(barBrush, barX, y, barWidth, barHeight, g);

                float centerX = x + (slotWidth / 2);
                linePoints[i] = new PointF(centerX, y);
            }
        }

        public void drawRow(Graphics g, Brush textBrush, Font dataFont, int listX, int listY, int lineHeight, Object[] rowElements, int currentY, int horizSpacing)
        {
            
            g.DrawString(rowElements[0].ToString(), dataFont, textBrush, listX, currentY);
            g.DrawString(rowElements[1].ToString(), dataFont, textBrush, listX + horizSpacing, currentY);
        }
        public void drawTable(Brush textBrush, string headerX, string headerY, Font dataHeaderFont, Font dataFont, int listX, 
            int listY, int lineHeight, int horizSpacing, int vertSpacing, Graphics g) {

            g.DrawString(headerX, dataHeaderFont, textBrush, listX, listY);
            g.DrawString(headerY, dataHeaderFont, textBrush, listX + horizSpacing, listY);

            for (int i = 0; i < years.Length; i++)
            {
                int currentY = listY + vertSpacing + (i * lineHeight);
                Object[] rowElements = { years[i], revenue[i] };
                drawRow(g, textBrush, dataFont, listX, listY, lineHeight, rowElements, currentY, horizSpacing);
            }
        }
    }
}
