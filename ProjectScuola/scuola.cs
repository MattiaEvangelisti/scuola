using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProgrammaScuola
{
    internal class scuola
    {
        private string nome, indirizzo;
        private DateTime orarioApertura, orarioChiusura;

        public string insertAlunno(string nome, string cognome, string anni)
        {
            alunno alunno = new alunno(nome, cognome, anni);
            return nome;
        }
        public string ricercaAlunno()
        {
            return alunno;
        }

        public int numAlunni()
        {
            int i = 0;
            return i;
        }
    }
}
