using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coisaboa
{
    public class Person
    {
        public int Id;
        public string Name;
        public int Life;
        public int Strengh;
        public Person(string nome, int vida, int forca) 
        {
            Name = nome;
            Life = vida;
            Strengh = forca;
        }
    }
}
