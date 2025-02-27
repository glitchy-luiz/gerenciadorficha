using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coisaboa
{
    public class VariaveisGlobais
    {
        public static int MinhaVariavelGlobal = 42;
        public static string TextoGlobal = "Olá, Mundo!";
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
