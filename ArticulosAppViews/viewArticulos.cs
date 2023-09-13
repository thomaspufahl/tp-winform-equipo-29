using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticulosAppViews
{
    public partial class viewArticulos : Form
    {
        public viewArticulos()
        {
            InitializeComponent();
        }

        private void viewArticulos_SizeChanged(object sender, EventArgs e)
        {
            int width = Size.Width;

            Size smallSize = new Size(314, 537);
            Size bigSize = new Size(600, 537);

            Size textBoxSmallSize = new Size(351, 22);
            Size textBoxBigSize = new Size(432, 22);

            if (width >= 1280)
            {
                panelDetails.Size = bigSize;
                textBoxBuscar.Size = textBoxBigSize;
            }
            else
            {
                panelDetails.Size = smallSize;
                textBoxBuscar.Size = textBoxSmallSize;
            }
        }
    }
}
