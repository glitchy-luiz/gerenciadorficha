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
    public partial class Personagens : Form
    {
        public Personagens()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Global.chars.Count; i++)
            {
                listBox1.Items.Add($"Nome: {Global.chars[i].Name}, Vida: {Global.chars[i].Life}, Força: {Global.chars[i].Strengh}");
            }
        }
    }
}
