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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            for (int i = 0; i < Global.chars.Count; i++)
            {
                if (Global.chars[i].Name == nome)
                {
                    label3.Text = Global.chars[i].Name;
                    label4.Text = Global.chars[i].Life.ToString();
                    label5.Text = Global.chars[i].Strengh.ToString();
                }
                else
                {
                    label2.Text = "Nenhum personagem foi encontrado!";
                }
            }
        }
    }
}
