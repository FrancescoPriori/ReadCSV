using System;
using System.Collections.Generic;
using System.IO;
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

namespace priori.francesco._4h.ReadCSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<utente> valori = new List<utente>();
            try
            {
                StreamReader fin = new StreamReader("utenti.csv");

                while (!fin.EndOfStream)
                {
                    string str = fin.ReadLine();
                    string[] colonne = str.Split(':');
                    utente u = new utente { nome = colonne[0], cognome = colonne[1] };
                    valori.Add(u);
                }


            }

            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }





            dgDati.ItemsSource = valori;
        }
    }


    public class utente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
    }
}

