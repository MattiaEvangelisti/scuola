using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaScuola
{
    internal class alunno
    {
        private string nome, cognome;
        private int anni;

        public string toString()
        { return ("Nome: " + nome + ", cognome: " + cognome + ", età: " + anni.ToString()); }

        public string classi()
        {
            string anno = "";

            if (anni < 16)
            { anno = "Biennio"; }
            else
            { anno = "Triennio"; }

            return anno;
        }

        #region metodi get e set
        //GET
        public string getNome()
        { return nome; }
        public string getCognome()
        { return cognome; }
        public int getAnni()
        { return anni; }

        //SET
        public void setNome(string nuovoNome)
        { nome = nuovoNome; }
        public void setCognome(string nuovoCognome)
        { cognome = nuovoCognome; }
        public void setAnni(int nuoviAnni)
        { anni = nuoviAnni; }
        #endregion
    }
}
