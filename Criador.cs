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
    public partial class Criador : Form
    {
        public Criador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string nome = textBox1.Text;
                int vida = int.Parse(textBox2.Text);
                int forca = int.Parse(textBox3.Text);
                Person person = new Person(nome, vida, forca);
                Global.chars.Add(person);
                label4.Text = $"O personagem {nome} foi adicionado";
            } else
            {
                label4.Text = "Não pode haver campos vazios";
            }
        }
    }
}
