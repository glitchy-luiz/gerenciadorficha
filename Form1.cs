using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coisaboa
{
    public partial class Form1 : Form
    {
        Criador criador = new Criador();
        Personagens personagens = new Personagens();
        Status status = new Status();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            criador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personagens.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status.Show();
        }
    }
}
