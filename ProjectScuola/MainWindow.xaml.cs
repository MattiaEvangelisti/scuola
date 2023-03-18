using ProgrammaScuola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectScuola
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        scuola Scuola = new scuola();
        string nome, cognome;
        int anni;

        private void btnRicercaAlunno_Click(object sender, RoutedEventArgs e)
        {
            cognome = txtRicercaCognome.Text;
            Scuola.RicercaAlunno(cognome);
        }

        private void btnModAlunno_Copy1_Click(object sender, RoutedEventArgs e)
        {
            anni = int.Parse(txtAnni.Text);
            Scuola.RicercaAlunni(anni);
        }

        private void btnAlunni_Click(object sender, RoutedEventArgs e)
        {
            Scuola.RicercaAlunni();
        }

        private void btnInsAlunno_Click(object sender, RoutedEventArgs e)
        {
            nome = txtNome.Text;
            cognome= txtCognome.Text;
            anni = int.Parse(txtAnni.Text);
            Scuola.InsertAlunno(nome, cognome, anni);
        }
    }
}
