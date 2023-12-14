using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Mascota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtener el tamaño de la pantalla
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Obtener una posición aleatoria dentro de la pantalla
            int newX = random.Next(0, screenWidth - this.Width);
            int newY = random.Next(0, screenHeight - this.Height);

            // Mover la ventana a la posición aleatoria
            this.Location = new System.Drawing.Point(newX, newY);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            // Mover la ventana a una nueva posición
            this.Location = new System.Drawing.Point(100, 100);
        }
        
    }


    }

