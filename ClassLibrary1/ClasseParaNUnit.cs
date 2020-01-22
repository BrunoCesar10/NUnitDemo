using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNUnit
{
    public class ClasseParaNUnit
    {
        public int Soma(int i, int j)
        {
            return i + j;
        }
        
        public int Subtracao(int i, int j)
        {
            return i - j;
        }
        public int Multiplicacao(int i, int j)
        {
            return i * j;
        }

        public int Divisao(int i, int j)
        {
            return i / j;
        }

        public string Concatenacao(string str1, string str2)
        {
            return "Hello " + str1 + " " + str2;
        }
    }
}
