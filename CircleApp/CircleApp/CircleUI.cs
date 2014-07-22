using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class CircleUI : Form
    {
        Circle aCircle = new Circle();

        public CircleUI()
        {
            InitializeComponent();
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            string result = aCircle.GetDiameter(radiusTextBox.Text);
            MessageBox.Show(result);
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            string result = aCircle.GetPerimeter(radiusTextBox.Text);
            MessageBox.Show(result);
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            string result = aCircle.GetArea(radiusTextBox.Text);
            MessageBox.Show(result);
        }
    }
}
