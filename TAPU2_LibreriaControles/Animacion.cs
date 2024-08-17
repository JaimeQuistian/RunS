using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU2_LibreriaControles
{
    public partial class Animacion : UserControl
    {
        int contador = 0;
        public Animacion()
        {
            InitializeComponent();
            //cambiar color de fondo
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.DoubleBuffered= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            switch (contador)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources._4;
                    break;
                default:
                    contador = 0;
                    break;
            }
        }
    }
}
