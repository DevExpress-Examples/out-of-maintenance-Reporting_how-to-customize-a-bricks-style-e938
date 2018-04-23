using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
// ...

namespace ChangeBrickStyle {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string s = "XtraPrinting Library";
            BrickGraphics brickGraph = printingSystem1.Graph;
            VisualBrick visBrick = new VisualBrick();

            // Specify the style
            BrickStyle bStyle = new BrickStyle(BorderSide.Bottom, 2, Color.Gold, Color.Navy,
                Color.DodgerBlue, new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic),
                new BrickStringFormat(StringAlignment.Far, StringAlignment.Near));

            // Start the report generation.
            printingSystem1.Begin();

            // Create bricks.
            brickGraph.Modifier = BrickModifier.Detail;
            visBrick = brickGraph.DrawString(s, new RectangleF(0, 0, 250, 40));
            visBrick = brickGraph.DrawString(s, new RectangleF(0, 40, 250, 40));

            // Apply the style to the current brick.
            visBrick.Style = bStyle;

            // Finish the report generation.
            printingSystem1.End();
        }


    }
}
