using System;
using System.Windows.Forms;

namespace NombreDelProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Aquí puedes añadir el código que deseas que se ejecute cuando se carga el formulario
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.example.com");
        }
    }
}


